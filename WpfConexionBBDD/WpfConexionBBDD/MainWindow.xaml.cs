using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfConexionBBDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Conexion a base de datos
            string miConexion = ConfigurationManager.ConnectionStrings["WpfConexionBBDD.Properties.Settings.FirstDataBaseConnectionString"].ConnectionString;
            //Conexion sql
            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();
            MuestraPedidopTd();
        }

        //Extraer info desde la BBDD
        private void MuestraClientes()
        {
            try
            { //consulta
                string consulta = "SELECT * FROM Cliente";
                //Adaptador para la consulta
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);

                    ListaClientes.DisplayMemberPath = "Nombrre";
                    ListaClientes.SelectedValuePath = "Id";
                    ListaClientes.ItemsSource = clientesTabla.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }

        private void MuestraPedido()
        {
            try
            {
                //consulta parametrica
                string consulta = "SELECT * FROM Pedido P INNER JOIN Cliente C ON C.Id = P.CodCliente " +
                    "WHERE C.Id = @ClienteId";
                //Pra consultal con parametro
                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);
                //Adaptador para la consulta
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {

                    sqlComando.Parameters.AddWithValue("@ClienteId", ListaClientes.SelectedValue);


                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    Pedidos.DisplayMemberPath = "FechaPedido";
                    Pedidos.SelectedValuePath = "Id";
                    Pedidos.ItemsSource = pedidosTabla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void MuestraPedidopTd()
        {
            try
            {//consulta con concatenacion
                string consulta = "SELECT *, CONCAT(CodCliente, '  ',FechaPedido, '  ' , FormaPago) AS InfoCompleta FROM Pedido";
                //Adaptador para la consulta
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable pedidosTdTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTdTabla);

                    PedidosTd.DisplayMemberPath = "InfoCompleta";
                    PedidosTd.SelectedValuePath = "Id";
                    PedidosTd.ItemsSource = pedidosTdTabla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        SqlConnection miConexionSql;

        private void ListaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedido();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(PedidosTd.SelectedValue.ToString());

            string consulta = "DELETE FROM Pedido WHERE Id = @PedidoId";

            SqlCommand miSqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlComando.Parameters.AddWithValue("@PedidoId", PedidosTd.SelectedValue);

            miSqlComando.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraPedidopTd();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO Cliente (Nombrre) VALUES (@nombre)";

            SqlCommand miSqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlComando.Parameters.AddWithValue("@nombre", InsertaCliente.Text);

            miSqlComando.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();

            InsertaCliente.Text = "";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM Cliente WHERE Id = @ClienteId";

            SqlCommand miSqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlComando.Parameters.AddWithValue("@ClienteId", ListaClientes.SelectedValue);

            miSqlComando.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)ListaClientes.SelectedValue);

            

            try
            { //consulta
                string consulta = "SELECT Nombrre FROM Cliente WHERE Id = @ClId";

                SqlCommand miSqlComando = new SqlCommand(consulta, miConexionSql);
                //Adaptador para la consulta
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlComando);

                using (miAdaptadorSql)
                {
                    miSqlComando.Parameters.AddWithValue("@ClId", ListaClientes.SelectedValue);

                    DataTable ClientesTabla = new DataTable();

                    miAdaptadorSql.Fill(ClientesTabla);

                    ventanaActualizar.CuadroActualiza.Text = ClientesTabla.Rows[0]["Nombrre"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            ventanaActualizar.ShowDialog();

            MuestraClientes();
        }
    }
}

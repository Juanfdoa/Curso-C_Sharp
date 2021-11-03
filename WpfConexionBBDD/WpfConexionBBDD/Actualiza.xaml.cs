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
    /// Interaction logic for Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        SqlConnection miConexionSql;

        private int Z;


        public Actualiza(int elId)
        {
            InitializeComponent();

            Z = elId;
            //Conexion a base de datos
            string miConexion = ConfigurationManager.ConnectionStrings["WpfConexionBBDD.Properties.Settings.FirstDataBaseConnectionString"].ConnectionString;
            //Conexion sql
            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE Cliente SET Nombrre = @nombre WHERE Id =" + Z;

            SqlCommand miSqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlComando.Parameters.AddWithValue("@nombre", CuadroActualiza.Text);

            miSqlComando.ExecuteNonQuery();

            miConexionSql.Close();

            this.Close(); //para cerrar la ventana automaticamente



        }
    }
}

using System;
using System.Collections.Generic;
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

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> ListaPob = new List<Poblaciones>();

            ListaPob.Add(new Poblaciones() { Poblacion1 = "Medellin", Poblacion2 = "Bogota", Temperatura1 = 30, Temperatura2 = 20, DiferenciaTemp=10 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Santa Marta", Poblacion2 = "Barranquilla", Temperatura1 =40 , Temperatura2 = 38, DiferenciaTemp = 2 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Cali", Poblacion2 = "Ibague", Temperatura1 = 29, Temperatura2 = 18, DiferenciaTemp = 11 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Cartagena", Poblacion2 = "Cucuta", Temperatura1 = 36, Temperatura2 = 25, DiferenciaTemp = 11 });
            lista.ItemsSource = ListaPob;   //Unir la lista del codigo xaml con la lista c#
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                MessageBox.Show((lista.SelectedItem as Poblaciones).Poblacion1 + " " +
                (lista.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                (lista.SelectedItem as Poblaciones).Poblacion2 + " " +
                (lista.SelectedItem as Poblaciones).Temperatura2 + "°C ");
            }
            else MessageBox.Show("Debes seleccionar un elemento");
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show((lista.SelectedItem as Poblaciones).Poblacion1 + " " +
                (lista.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                (lista.SelectedItem as Poblaciones).Poblacion2 + " " +
                (lista.SelectedItem as Poblaciones).Temperatura2 + "°C ");

        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTemp { get; set; }
    }
}

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

namespace PrimeraInterfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Ventana Emergente
            //MessageBox.Show("La forma de pila pone todos los elementos uno bajo el otro");

            Console.WriteLine("Le haz dado al boton central");
        }

       

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le haz dado al boton Izquierdo");
        }
    }
}

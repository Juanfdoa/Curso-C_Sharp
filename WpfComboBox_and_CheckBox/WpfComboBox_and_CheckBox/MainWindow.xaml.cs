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

namespace WpfComboBox_and_CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();

            ListaCapitales.Add(new Capitales { NombreCapital = "Bogota"});
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capitales { NombreCapital = "DF" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });

            Capitales.ItemsSource = ListaCapitales;

        }

        private void General_Checked(object sender, RoutedEventArgs e)
        {
            Bogota.IsChecked = true;
            Madrid.IsChecked = true;
            Lima.IsChecked = true;
            DF.IsChecked = true;
            Santiago.IsChecked = true;

        }

        private void General_Unchecked(object sender, RoutedEventArgs e)
        {
            Bogota.IsChecked = false;
            Madrid.IsChecked = false;
            Lima.IsChecked = false;
            DF.IsChecked = false;
            Santiago.IsChecked = false;

        }

        private void Individual_checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Bogota.IsChecked == true && Lima.IsChecked == true && DF.IsChecked == true && Santiago.IsChecked == true)
            {
                General.IsChecked = true;

            }
            else
            {
                General.IsChecked = null;
            }

        }

        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && DF.IsChecked == false && Santiago.IsChecked == false)
            {
                General.IsChecked = false;

            }
            else
            {
                General.IsChecked = null;
            }

        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}

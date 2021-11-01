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

namespace WpfDependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Registrar dependency propertie

        public int myPropertie
        {
            get { return (int)GetValue(MyDependencyPopertie); }

            set { SetValue(MyDependencyPopertie, value);  }
        }

        public static readonly DependencyProperty MyDependencyPopertie =
            DependencyProperty.Register("myPropertie", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

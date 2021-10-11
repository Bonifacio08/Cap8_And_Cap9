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

 
namespace Cap8_And_Cap9
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

        private void Ejec3_Clik(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ej3 = new Ejercicio3();
            ej3.Show();
        }

        private void Ejec5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ej5 = new Ejercicio5();
            ej5.Show();
        }


        private void Ejercicio1Cap9(object sender, RoutedEventArgs e)
        {
            Ejercicio1Cap9 ejeCap9 = new Ejercicio1Cap9();
            ejeCap9.Show();
        }

        private void Ejercicio2Cap9(object sender, RoutedEventArgs e)
        {
            Ejercicio2Cap9 eje2Cap9 = new Ejercicio2Cap9();
            eje2Cap9.Show();
        }
    }
}
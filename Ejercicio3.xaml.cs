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
using System.Windows.Shapes;

namespace Cap8_And_Cap9
{
    /// <summary>
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();

        }

        private void BtnBuscar(object sender, RoutedEventArgs e)
        {
            String formato;
            formato = String.Format("{0:h:M tt  yyyy/mm/MM}", DateTime.Now);
            LbHora.Content = formato;
        }
    }
}

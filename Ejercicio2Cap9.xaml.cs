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
    /// Interaction logic for Ejercicio2Cap9.xaml
    /// </summary>
    public partial class Ejercicio2Cap9 : Window
    {
        CuentaBancaria Cb = new CuentaBancaria();
        public Ejercicio2Cap9()
        {
            InitializeComponent();
        }
        

        public struct CuentaBancaria
        {
            public string Nombre;
            public string Apellido;
            public string tipoDeCuenta;
            public double CantidadDeEfectivo;
        }

        private void GUARDAR(object sender, RoutedEventArgs e)
        {
            //art.NombreArt = TextArticulo.Text;
            Cb.Nombre = TextNombre.Text;
            Cb.Apellido = TextApellido.Text;
            Cb.tipoDeCuenta = TextTipoDeCuenta.Text;
            Cb.CantidadDeEfectivo = Convert.ToDouble(TextCantidadEfectivo.Text);
            //Validacion de que se guardo
            MessageBox.Show("Guardado!!", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

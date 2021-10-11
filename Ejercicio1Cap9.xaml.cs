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
    /// Interaction logic for Ejercicio1Cap9.xaml
    /// </summary>
    public partial class Ejercicio1Cap9 : Window
    {
        Articulos art = new Articulos();
        public Ejercicio1Cap9()
        {
            InitializeComponent();
        }

        public struct Articulos
        {
            public string NombreArt;
            public string DescripcionArt;
            public int PrecioArt;
            public int CantidadArt;
        }
        
        private void Guardar(object sender, RoutedEventArgs e)
        {
            art.NombreArt = TextArticulo.Text;
            art.DescripcionArt = TextDescripcionArt.Text;
            art.PrecioArt = Convert.ToInt32(TextPrecioArt.Text);
            art.CantidadArt = Convert.ToInt32(TextCantidadArt.Text);

            MessageBox.Show("Guardado!!", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Mostrar(object sender, RoutedEventArgs e)
        {
            TextResNombre.Text = art.NombreArt;
            TextResPrecioArt.Text = Convert.ToString(art.PrecioArt); 
            TextResCantidadArt.Text = Convert.ToString(art.CantidadArt);
            TextResDescripcionArt.Text = art.DescripcionArt;
        }
    }
}

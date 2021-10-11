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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        //Varibles a utilizar
        //string[] ArrayCad1;
        char aux1, aux2;
        int p1, p2;



        private void MMG(object sender, RoutedEventArgs e)
        {
          
            string []auxCad1 = new string[2];
            string Cad1 = TextCad1.Text;
           
            char[] ArrayCad1 = Cad1.ToArray();
            //IMPRIMIR
            for (int i = 1; i<3; i++)
            {
                aux1 = ArrayCad1[i];
                p1 = i - 1;

                while (aux1 < ArrayCad1[p1] && p1 >= 1)
                {
                    ArrayCad1[p1 + 1] = ArrayCad1[p1];
                    p1 = p1 - 1;
                }
                if(ArrayCad1[p1] <= aux1)
                    ArrayCad1[p1 + 1] = aux1;
                else
                {
                    ArrayCad1[p1 + 1] = ArrayCad1[p1];
                    ArrayCad1[p1] = aux1;
                }    
            }
            auxCad1[0] = new string(ArrayCad1);
            ResCad1.Text = auxCad1[0];

            //..

            string[] auxCad2 = new string[2];
            string Cad2 = TextCad2.Text;

            char[] ArrayCad2 = Cad2.ToArray();
            //IMPRIMIR
            for (int i = 1; i < 3; i++)
            {
                aux1 = ArrayCad2[i];
                p1 = i - 1;

                while (aux2< ArrayCad2[p2] && p2 >= 1)
                {
                    ArrayCad2[p2 + 1] = ArrayCad2[p2];
                    p2 = p2 - 1;
                }
                if (ArrayCad2[p2] <= aux2)
                    ArrayCad1[p2 + 1] = aux2;
                else
                {
                    ArrayCad2[p2 + 1] = ArrayCad2[p2];
                    ArrayCad2[p2] = aux2;
                }
            }
            auxCad2[0] = new string(ArrayCad2);
            ResCad2.Text = auxCad2[0];


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Tarea_BB2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int valor1;
        private int resultado;
        public MainWindow()
        {
            InitializeComponent();

        }
        public class Variables
        {
            


        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void boton0_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "0";
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "1";
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "2";
        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "3";
        }

        private void boton4_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "4";
        }

        private void boton5_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "5";
        } 

        private void boton6_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "6";
        }

        private void boton7_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "7";
        }

        private void boton8_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "8";
        }

        private void boton9_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + "9";
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            valor1 = Convert.ToInt32(Texto.Text);
            Texto.Text = " ";
            resultado = valor1;
            if (resultado % 5 == 0 && resultado % 3 == 0)
            {
                MessageBox.Show("FizzBuzz");
                return;
            }

            if (resultado % 5 == 0)
            {
                MessageBox.Show("Buzz");
                return;
            }
            if (resultado % 3 == 0 )
            {
                MessageBox.Show("Fizz");
                return;
            }


            else
            {
                MessageBox.Show(Convert.ToString("Tu número es: " + valor1));
            }

        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = " ";
        }
    }
}

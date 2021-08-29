using AppDemoWPF01.Model;
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

namespace AppDemoWPF01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            operacion(1);
        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            operacion(2);
        }

        private void btnMultiplica_Click(object sender, RoutedEventArgs e)
        {
            operacion(3);
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operacion(4);
        }

        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            //limpia cajas
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
        }

        private void btnEX_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //instanciar objeto de la clase Calculadora
        Calculadora cal = new Calculadora();

        private void operacion(int opcion)
        {
            decimal res = 0;
            switch (opcion)
            {
                case 1:
                    res = cal.Sumar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 2:
                    res = cal.Restar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 3:
                    res = cal.Multiplicar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 4:
                    res = cal.Dividir(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
            }
            txtResultado.Text = res.ToString();
        }

    }
}

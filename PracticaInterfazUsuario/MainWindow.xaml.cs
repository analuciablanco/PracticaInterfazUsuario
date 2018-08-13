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

namespace PracticaInterfazUsuario
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

        private void sldPorcentaje_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblPorcentaje.Text = Math.Round(sldPorcentaje.Value).ToString() + "%";

            float total = float.Parse(txtCantidad.Text);
            float porcentajePropina = (float)Math.Round(sldPorcentaje.Value);
            float propina = total * (porcentajePropina / 100);

            float totalConPropina = total + propina;

            lblPropinaCantidad.Text = "$" + propina.ToString();
            lblTotalCantidad.Text = "$" + totalConPropina.ToString();
        }

        private void txtCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

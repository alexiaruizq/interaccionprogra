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

namespace interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnMiBoton.Click += BtnMiBoton_Click;

        }

        private void BtnMiBoton_Click(object sender, RoutedEventArgs e)
        {
            lblAlexiaRuiz.Text = "Ruiz Alexia";
            lblAlexiaRuiz.FontSize = 29;
            lblAlexiaRuiz.Foreground = Brushes.BlueViolet;
        }

        private void BtnsegudnoBoton_Click(object sender, RoutedEventArgs e)
        {
            lblAlexiaRuiz.Text = "Millanes Fatima";
            lblAlexiaRuiz.FontSize = 22;
            lblAlexiaRuiz.Foreground = Brushes.Black;


        }

        private void BtntercerBoton_Click(object sender, RoutedEventArgs e)
        {

            lblAlexiaRuiz.Text = "Campbell Raul";
            lblAlexiaRuiz.FontSize = 26;
            lblAlexiaRuiz.Foreground = Brushes.Purple;

        }
    }
}

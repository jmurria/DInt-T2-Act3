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
using System.IO;
using System.Drawing;

namespace Act3
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

        private void OpacidadAlta_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1.0;
        }

        private void OpacidadMedia_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
        }

        private void OpacidadBaja_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.3;
        }

        private void AjusteFill_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void AjusteUniform_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void AjusteUniformToFill_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void AjusteNone_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}

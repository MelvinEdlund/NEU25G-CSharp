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

namespace WPF_Kontroller
{
    /// <summary>
    /// Interaction logic for Uppgift_4.xaml
    /// </summary>
    public partial class Uppgift_4 : Window
    {
        public Uppgift_4()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (positionLabel != null)
            {
                double x = xSlider.Value;
                double y = ySlider.Value;

                Canvas.SetLeft(positionLabel, x);
                Canvas.SetTop(positionLabel, y);

                positionLabel.Content = $"x= {x:F0}, y= {y:F0}";
            }
        }
    }
}

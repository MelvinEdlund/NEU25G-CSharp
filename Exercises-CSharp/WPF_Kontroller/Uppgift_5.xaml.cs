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
    /// Interaction logic for Uppgift_5.xaml
    /// </summary>
    public partial class Uppgift_5 : Window
    {
        private double currentX = 0;
        private double currentY = 0;
        public Uppgift_5()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = xySlider.Value;

            if (!lockX.IsChecked ?? true)
                currentX = value;

            if (!lockY.IsChecked ?? true)
                currentY = value;

            Canvas.SetLeft(positionLabel, currentX);
            Canvas.SetTop(positionLabel, currentY);

            positionLabel.Content = $"X= {currentX:F0}, Y= {currentY:F0}";
        }
    }
}

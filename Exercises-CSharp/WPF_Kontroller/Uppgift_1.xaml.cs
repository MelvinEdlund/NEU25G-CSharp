using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Kontroller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            int count = 0;
        int labelCount = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            clickCounterButton.Content = "Click: "+ count;
        }

        private void increase_Click(object sender, RoutedEventArgs e)
        {
            if (labelCount < 20)
            {
                ++labelCount;
                countLabel.Content = labelCount;
                slider.Value = labelCount;
             }

        }

        private void decrease_Click(object sender, RoutedEventArgs e)
        {
            if (labelCount > 0)
            {
                --labelCount;
                countLabel.Content = labelCount;
                slider.Value = labelCount;
            }

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelCount = Convert.ToInt32(e.NewValue);
            countLabel.Content = labelCount;
            
        }
    }
}
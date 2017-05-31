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

namespace Cosmetics
{
    /// <summary>
    /// Interaction logic for ColorCosm.xaml
    /// </summary>
    public partial class ColorCosm : Page
    {
        public ColorCosm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchingPage());
        }

        private void DoneColorButton_Click(object sender, RoutedEventArgs e)
        {
            if (ColorComboBox.Text == "Face")
            {
                NavigationService.Navigate(new Result(ColorComboBox.Text));
            }
            else if (ColorComboBox.Text == "Eyes")
            {
                NavigationService.Navigate(new Result(ColorComboBox.Text));
            }
            else if (ColorComboBox.Text == "Lips")
            {
                NavigationService.Navigate(new Result(ColorComboBox.Text));
            }
            else
            {
                MessageBox.Show("Shoose any category");
            }
        }
    }
}

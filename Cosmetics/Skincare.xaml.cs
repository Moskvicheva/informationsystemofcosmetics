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
    /// Interaction logic for Skincare.xaml
    /// </summary>
    public partial class Skincare : Page
    {
        public Skincare()
        {
            InitializeComponent();
        }

        private void SkinDoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (SkinComboBox.Text == "Eyes and lips")
            {
                NavigationService.Navigate(new Result(SkinComboBox.Text));
            }
            else if (SkinComboBox.Text == "Cleansing")
            {
                NavigationService.Navigate(new Result(SkinComboBox.Text));
            }
            else if (SkinComboBox.Text == "Moisturising")
            {
                NavigationService.Navigate(new Result(SkinComboBox.Text));
            }
            else if (SkinComboBox.Text == "Makeup remove")
            {
                NavigationService.Navigate(new Result(SkinComboBox.Text));
            }
            else
            {
                MessageBox.Show("Choose any category");
            }
        }

        private void SkinArrowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchingPage());
        }
    }
}

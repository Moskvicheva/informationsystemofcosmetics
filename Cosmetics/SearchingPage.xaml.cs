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
    /// Interaction logic for SearchingPage.xaml
    /// </summary>
    public partial class SearchingPage : Page
    {
        public SearchingPage()
        {
            InitializeComponent();
        }

        private void SearchButton_MouseEnter(object sender, MouseEventArgs e)
        {
            SearchButton.FontSize = 20;
        }

        private void SearchButton_MouseLeave(object sender, MouseEventArgs e)
        {
            SearchButton.FontSize = 12;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.Text == "Color cosmetics")
            {
                NavigationService.Navigate(new ColorCosm());
            }
            else if (comboBox.Text == "Skincare")
            {
                NavigationService.Navigate(new Skincare());
            }
            else
            {
                MessageBox.Show("Choose any category");
            }
        }

        private void SearchButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateNew());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Result(DeleteButton.Content.ToString()));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Result(EditButton.Content.ToString()));
        }
    }
}

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

namespace Cosmetics
{
    /// <summary>
    /// Interaction logic for CreateNew.xaml
    /// </summary>
    public partial class CreateNew : Page
    {
        public CreateNew()
        {
            InitializeComponent();
        }

        private void AddArrowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchingPage());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Done. Go back to the searching page using the arrow below");
            string filename = "";
            switch(AddCategoryComboBox.Text)
            {
                case "Color cosmetics: face":
                    {
                        filename = "macface.txt";
                    } break;
                case "Color cosmetics: eyes":
                    {
                        filename = "maceyes.txt";
                    } break;
                case "Color cosmetics: lips":
                    {
                        filename = "maclips.txt";
                    } break;
                case "Skincare: eyes and lips":
                    {
                        filename = "example.txt";
                    } break;
                case "Skincare: cleansing":
                    {
                        filename = "skincareclean.txt";
                    } break;
                case "Skincare: moisturising":
                    {
                        filename = "skincaremoist.txt";
                    } break;
                case "Skincare: makeup remove":
                    {
                        filename = "skincareremove.txt";
                    } break;
                default: break;
            }
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine(NameTextBox.Text + "*" + DescrTextBox.Text + "*" + PriceTextBox.Text);
            sw.Close();
        }
    }
}

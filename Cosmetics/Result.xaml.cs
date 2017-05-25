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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        public Result(string parametr)
        {
            InitializeComponent();
            switch(parametr)
            {
                case "Eyes and lips":
                    {
                        

                    } break;
                case "Cleansing":
                    {
                        StreamReader sr = new StreamReader("skincareclean.txt");
                    } break;
                case "Moisturising":
                    {
                        StreamReader sr = new StreamReader("skincaremoist.txt");
                    } break;
                case "Makeup remove":
                    {
                        StreamReader sr = new StreamReader("skincareremove.txt");
                    } break;
                case "Face":
                    {
                        StreamReader sr = new StreamReader("macface.txt");
                    } break;
                case "Eyes":
                    {
                        StreamReader sr = new StreamReader("maceyes.txt");
                    } break;
                case "Lips":
                    {
                        StreamReader sr = new StreamReader("maclips.txt");
                    } break;

            }
        }


        private void ResultArrowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchingPage());
        }
    }
}

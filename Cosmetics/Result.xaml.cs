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
        List<Products> result = new List<Products>();
        string filename;
        public Result(string parametr)
        {
            InitializeComponent();
            switch(parametr)
            {
                case "Eyes and lips":
                    {
                        filename = "example.txt";
                        StreamReader sr = new StreamReader(filename);
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));
                            
                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }

                    } break;
                case "Cleansing":
                    {
                        filename = "skincareclean.txt";
                        StreamReader sr = new StreamReader(filename);
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }

                    } break;
                case "Moisturising":
                    {
                        filename = "skincaremoist.txt";
                        StreamReader sr = new StreamReader("skincaremoist.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Makeup remove":
                    {
                        filename = "skincareremove.txt";
                        StreamReader sr = new StreamReader("skincareremove.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Face":
                    {
                        filename = "macface.txt";
                        StreamReader sr = new StreamReader("macface.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Eyes":
                    {
                        filename = "maceyes.txt";
                        StreamReader sr = new StreamReader("maceyes.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Lips":
                    {
                        filename = "maclips.txt";
                        StreamReader sr = new StreamReader("maclips.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;

            }
        }


        private void ResultArrowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchingPage());
        }

        private void ResultSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Clear();
            foreach (Products product in result)
            {
                if (product.Name.Contains(SearchTextBox.Text))
                {
                    ResultTextBox.AppendText(product.productsshow());
                    ResultTextBox.AppendText("\n");
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e) //delete
        {
            StreamWriter sw = new StreamWriter(filename);
            string[] mass = ResultTextBox.Text.Split('\n');
            foreach(string line in mass)
            {
                sw.WriteLine(line);
            }
            sw.Close();
            MessageBox.Show("Done");
        }
    }
}

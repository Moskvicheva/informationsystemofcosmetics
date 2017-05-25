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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void StartButton_MouseEnter(object sender, MouseEventArgs e)
        {
            StartButton.FontSize = 20;

        }

        private void StartButton_MouseLeave(object sender, MouseEventArgs e)
        {
            StartButton.FontSize = 14;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            bool success = false;
            StreamReader sr = new StreamReader("Loginpassword.txt");
            while (!sr.EndOfStream)
            {
                if(sr.ReadLine() == (LoginTextBox.Text + " " + PasswordBox.Password).ToString())
                {
                    NavigationService.Navigate(new SearchingPage());
                    success = true;
                }
            }
            if (!success)
            {
                MessageBox.Show("Incorrect login and/or password");
            }
        }
    }
}

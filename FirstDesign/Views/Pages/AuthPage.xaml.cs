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

namespace FirstDesign.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "1" && password.Text == "1")
            {
                MessageBox.Show("Добро пожаловать, ");
                NavigationService.Navigate(new MainPage());
            } 
        }

        private void SwapBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}

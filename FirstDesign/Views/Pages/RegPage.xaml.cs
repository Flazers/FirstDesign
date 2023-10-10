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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (r_login == null || r_password == null || r_nickname == null)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }

            MessageBox.Show("Такой логин уже существует.");
            MessageBox.Show("Регистрация успешно прошла.");
            NavigationService.Navigate(new AuthPage());
        }
        private void SwapBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

    }
}

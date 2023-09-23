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
using FirstDesign.Views.Pages;

namespace FirstDesign.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new AuthPage();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            //Выход из приложения
            Application.Current.Shutdown();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //try..catch обработчик ошибок
            try
            {
                MainFrame.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("Нет страниц для перехода назад");
            }
        }
    }
}

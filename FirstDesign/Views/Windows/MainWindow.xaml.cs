using FirstDesign.Views.Pages;
using System;
using System.Windows;

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
    }
}

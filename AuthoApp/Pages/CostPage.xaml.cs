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
using AuthoApp.DB;
using AuthoApp.Pages;

namespace AuthoApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для CostPage.xaml
    /// </summary>
    public partial class CostPage : Page
    {
        public CostPage()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CostPage());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());
        }
    }
}

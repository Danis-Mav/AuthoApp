using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Pen = AuthoApp.DB.Pen;

namespace AuthoApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static ObservableCollection<Pen> pens { get; set; }
        public static ObservableCollection<TypePen> types { get; set; }
        public MainPage(/*User user*/)
        {
            InitializeComponent();
            pens = new ObservableCollection<Pen>(DBConnection.connection.Pen/*.Where(a => a.IsDeleted == false)*/.ToList());
            types = new ObservableCollection<TypePen>(DBConnection.connection.TypePen/*.Where(a => a.IsDeleted == false)*/.ToList());
            this.DataContext = this;
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

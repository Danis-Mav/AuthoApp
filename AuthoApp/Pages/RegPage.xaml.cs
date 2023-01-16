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

namespace AuthoApp.Pages
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

        private void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RegButton(object sender, RoutedEventArgs e)
        {
            var a = new User();
            a.Login = tb_Login.Text;
            a.Password = pb_Password.Password;
            DBConnection.connection.User.Add(a);
            DBConnection.connection.SaveChanges();
            NavigationService.GoBack();
        }
    }
}

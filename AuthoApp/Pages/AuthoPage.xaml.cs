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
using AuthoApp.Pages;
using AuthoApp.DB;

namespace AuthoApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthoPage.xaml
    /// </summary>
    public partial class AuthoPage : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public AuthoPage()
        {
            InitializeComponent();
        }

        private void RegButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void AuthButton(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<User>(DBConnection.connection.User.ToList());
            var z = users.Where(a => a.Login == tb_Login.Text && a.Password == pb_Password.Password).FirstOrDefault();
            if (z != null)
            {
                WindowMain taskWindow = new WindowMain(z);
                taskWindow.Show();

                
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}

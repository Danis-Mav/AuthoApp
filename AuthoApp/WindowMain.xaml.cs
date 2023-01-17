using AuthoApp.DB;
using AuthoApp.Pages;
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
using System.Windows.Shapes;

namespace AuthoApp
{
    /// <summary>
    /// Логика взаимодействия для WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain(User user)
        {
            InitializeComponent();
            frame_login.NavigationService.Navigate(new MainPage(user));
        }
    }
}

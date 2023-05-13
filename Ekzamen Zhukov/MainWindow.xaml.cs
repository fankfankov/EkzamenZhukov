using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using Ekzamen.Model;

namespace Ekzamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txbpass.IsEnabled = false;
        }

        public static class Globals
        {
            public static int UserRoles;
            public static user userinfo { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonNext1(object sender, RoutedEventArgs e)
        {
            var curentuser = AppData.db.user.FirstOrDefault(u => u.login == txblogin.Text);
            if(curentuser != null)
            {
                Globals.userinfo = curentuser;
                Globals.UserRoles = curentuser.roleID;
                txbpass.IsEnabled = true;
                button1.Visibility = Visibility.Hidden;
                button2.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Login doesnt exist!");
            }
        }

        private void ButtonNext2(object sender, RoutedEventArgs e)
        {
            var curentuser = AppData.db.user.FirstOrDefault(u => u.login == txblogin.Text && u.pass == txbpass.Text);
            if (curentuser != null)
            {
                Window1 window1 = new Window1();
                window1.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Password incorrect!");
            }
        }
    }
}

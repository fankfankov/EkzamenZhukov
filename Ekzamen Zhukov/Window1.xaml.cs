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

namespace Ekzamen
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            if (MainWindow.Globals.UserRoles == 1)
            {
                txbroles.Text = "Заказчик";
            }
            if (MainWindow.Globals.UserRoles == 2)
            {
                txbroles.Text = "Менеджер";
            }

            if (MainWindow.Globals.UserRoles == 3)
            {
                txbroles.Text = "Кладовщик";
            }
            if (MainWindow.Globals.UserRoles == 4)
            {
                txbroles.Text = "Дирекция";
            }
        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

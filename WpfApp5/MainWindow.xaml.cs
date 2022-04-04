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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Login = "admin";
            var Parol = "admin";

            if ((L.Text == Login) && (P.Password == Parol))
            {
                Window neww = new Window1();
                neww.Show();
                Close();
            }
            if ((L.Text == Login) && (P.Password != Parol))
            {
                MessageBox.Show("Не верный пароль");
            }
            if (L.Text != Login)
            {
                MessageBox.Show("Не верный логин");
            }
        }
    }
}

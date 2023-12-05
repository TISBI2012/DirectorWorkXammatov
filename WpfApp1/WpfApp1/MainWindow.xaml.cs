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
using WpfApp1.Pages;
using WpfApp1;

namespace WpfApp1
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

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBUserLogin.Text);
                if(user==null || user.Password != PBUserPassword.Password) 
            {
                MessageBox.Show("Данные не верны");
                return;
            }

            FirstFrame.Navigate(new HomePage());
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            FirstFrame.NavigationService.Navigate(new RegistationPage());
        }
    }
}

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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistationPage.xaml
    /// </summary>
    public partial class RegistationPage : Page
    {
        public RegistationPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;

        }

        public RegistationPage()
        {
            InitializeComponent();

        }

        User contextUser;
        
        

        private void BRegUser_Click(object sender, RoutedEventArgs e)
        {
            
                App.DB.User.Add(contextUser);
            App.DB.SaveChanges();
            
        }
    }
}

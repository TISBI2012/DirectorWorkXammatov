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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BComedi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ComediPage());
        }

        private void BHorror_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HorrorPage());
        }

        private void BDramas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DramsPage());
        }

        private void BFighters_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FightersPage());
        }
    } }

using KworkAndreev.Core;
using KworkAndreev.View.AdministratorPage.UserControls;
using KworkAndreev.View.LoginPage;
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

namespace KworkAndreev.View.AdministratorPage
{
    /// <summary>
    /// Логика взаимодействия для MainAdministratorPage.xaml
    /// </summary>
    public partial class MainAdministratorPage : Page
    {
        public MainAdministratorPage()
        {
            InitializeComponent();
        }

        private void MenuItemUser_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoUserControl());
        }

        private void MenuItemRequests_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoRequestsControl());
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }

        private void MenuItemOrders_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoManagmentInfoControl());

        }

        private void AddService_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoManagmentControl());
        }
    }
}

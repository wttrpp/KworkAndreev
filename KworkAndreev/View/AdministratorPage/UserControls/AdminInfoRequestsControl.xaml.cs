using KworkAndreev.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace KworkAndreev.View.AdministratorPage.UserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminInfoRequestsControl.xaml
    /// </summary>
    public partial class AdminInfoRequestsControl : UserControl
    {
        public AdminInfoRequestsControl()
        {
            InitializeComponent();
            DataManagmentInfo.ItemsSource = FrameNavigate.DB.Orders.OrderBy(u => u.OrdersID).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using KworkAndreev.Core;
using KworkAndreev.Model;
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
            int idOrders = ((sender as Button)?.DataContext as Order).OrdersID;
            var resultDeleteOneRequest = MessageBox.Show("Вы действительно хотите удалить запрос?", "Системное сообщение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Yes);
            if (resultDeleteOneRequest == MessageBoxResult.Yes)
            {
                Order order = (from u in FrameNavigate.DB.Orders where u.OrdersID == idOrders select u).SingleOrDefault();
                FrameNavigate.DB.Orders.Remove(order);
                FrameNavigate.DB.SaveChanges();
                DataManagmentInfo.ItemsSource = FrameNavigate.DB.Orders.OrderBy(u => u.OrdersID).ToList();
            }

        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            int idOrders = ((sender as Button)?.DataContext as Order).OrdersID;
            var resultDeleteOneRequest = MessageBox.Show("Одобрить заявку?", "Системное сообщение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Yes);
            if (resultDeleteOneRequest == MessageBoxResult.Yes)
            {
                Order order = (from u in FrameNavigate.DB.Orders where u.OrdersID == idOrders select u).SingleOrDefault();
                FrameNavigate.DB.Orders.Remove(order);
                FrameNavigate.DB.SaveChanges();
                DataManagmentInfo.ItemsSource = FrameNavigate.DB.Orders.OrderBy(u => u.OrdersID).ToList();
            }
        }
    }
}

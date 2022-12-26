using KworkAndreev.Core;
using KworkAndreev.Model;
using KworkAndreev.View.LoginPage;
using System;
using System.Collections.Generic;
using System.Data;
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


namespace KworkAndreev.View.UserPage
{
    /// <summary>
    /// Логика взаимодействия для MainUserPage.xaml
    /// </summary>
    public partial class MainUserPage : Page
    {
        public MainUserPage()
        {
            InitializeComponent();
            LViewServices.ItemsSource = FrameNavigate.DB.Services.OrderBy(u => u.SerivesID).ToList();
            List<string> a = (from u in FrameNavigate.DB.Users select u.Login).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            int idServices = ((sender as Button)?.DataContext as Service).SerivesID;
            var result = MessageBox.Show("Вы действительно хотите заказать данную услугу?", "Системное сообщение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                FrameNavigate.DB.Orders.Add(new Order
                {
                    ServicesID = idServices,
                    Status = "Обработка",
                    Times = DateTime.Today,
                    UserID = FrameNavigate.UserID
                });
                FrameNavigate.DB.SaveChanges();
                MessageBox.Show("В ближайшее время с вами свяжется администрация", "Системное сообщение");
            }
        }
    }
}

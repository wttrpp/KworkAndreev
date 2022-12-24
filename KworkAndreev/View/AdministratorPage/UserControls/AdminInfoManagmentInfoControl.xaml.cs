using KworkAndreev.Core;
using KworkAndreev.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
    /// Логика взаимодействия для AdminInfoManagmentInfoControl.xaml
    /// </summary>
    public partial class AdminInfoManagmentInfoControl : UserControl
    {
        public AdminInfoManagmentInfoControl()
        {
            InitializeComponent();
            DataOrderInfo.ItemsSource= FrameNavigate.DB.Services.OrderBy(u => u.ServicesID).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idServices = (DataOrderInfo.SelectedItem as Service).ServicesID;
            var resultDeleteOneOrder = MessageBox.Show("Вы действительно хотите удалить услугу?", "Системное сообщение", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (resultDeleteOneOrder== MessageBoxResult.Yes)
            {
                Service service = (from u in FrameNavigate.DB.Services where u.ServicesID== idServices select u).SingleOrDefault();
                FrameNavigate.DB.Services.Remove(service);
                FrameNavigate.DB.SaveChanges();
                DataOrderInfo.ItemsSource = FrameNavigate.DB.Services.OrderBy(u=> u.ServicesID).ToList();
            }

        }
    }
}

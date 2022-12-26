using KworkAndreev.Core;
using KworkAndreev.Model;
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

namespace KworkAndreev.View.AdministratorPage.UserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminInfoUserControl.xaml
    /// </summary>
    public partial class AdminInfoUserControl : UserControl
    {
        public AdminInfoUserControl()
        {
            InitializeComponent();
            DataUsersInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.Login).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var UserID = (DataUsersInfo.SelectedItem as User).UserID;
            User user = (from u in FrameNavigate.DB.Users where u.UserID == UserID select u).FirstOrDefault();
            FrameNavigate.DB.Users.Remove(user);
            FrameNavigate.DB.SaveChanges();
            DataUsersInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.Login).ToList();

        }
    }
}

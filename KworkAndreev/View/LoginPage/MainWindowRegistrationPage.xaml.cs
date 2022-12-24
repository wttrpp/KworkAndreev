using KworkAndreev.Core;
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

namespace KworkAndreev.View.LoginPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindowRegistrationPage.xaml
    /// </summary>
    public partial class MainWindowRegistrationPage : Page
    {
        public MainWindowRegistrationPage()
        {
            InitializeComponent();
        }

        private async void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tblogin.Text) || string.IsNullOrEmpty(TbPassword.Text) || string.IsNullOrEmpty(TbNumber.Text) || string.IsNullOrEmpty(TbEmail.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (FrameNavigate.DB.Users.Count(u => u.Login == Tblogin.Text) > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                FrameNavigate.DB.Users.Add(new Model.User
                {
                    Login = Tblogin.Text,
                    Password = TbPassword.Text,
                    Phone = TbNumber.Text,
                    Email = TbEmail.Text,
                    RoleID = 2
                });
                await FrameNavigate.DB.SaveChangesAsync();
                MessageBox.Show("Учетная запись создана!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());

            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}

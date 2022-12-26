using KworkAndreev.Core;
using KworkAndreev.Model;
using KworkAndreev.View.AdministratorPage;
using KworkAndreev.View.UserPage;
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
    /// Логика взаимодействия для MainWindowLoginPage.xaml
    /// </summary>
    public partial class MainWindowLoginPage : Page
    {
        public MainWindowLoginPage()
        {
            InitializeComponent();

        }

        private void BtnRegistracion_Click(object sender, RoutedEventArgs e)
        {
           FrameNavigate.FrameObject.Navigate(new MainWindowRegistrationPage());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                User userModel = FrameNavigate.DB.Users.FirstOrDefault(u => u.Login == Tblogin.Text && u.Password == TbRegister.Text);
                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных",
                       "Системное сообщение",
                       MessageBoxButton.OK,
                       MessageBoxImage.Error);
                }
                else
                {
                    FrameNavigate.UserID = userModel.UserID;
                    switch (userModel.RoleID)
                    {
                        case 1:
                            FrameNavigate.FrameObject.Navigate(new MainAdministratorPage());
                            break;
                        case 2:
                            FrameNavigate.FrameObject.Navigate(new MainUserPage());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системная ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

        }
    }
}

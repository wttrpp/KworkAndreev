using KworkAndreev.Core;
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

namespace KworkAndreev.View.EmployerPage
{
    /// <summary>
    /// Логика взаимодействия для MainEmployerPage.xaml
    /// </summary>
    public partial class MainEmployerPage : Page
    {
        public MainEmployerPage()
        {
            InitializeComponent();
        }


        private void TbLogout_Click(object sender, RoutedEventArgs e)
        {
          FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}

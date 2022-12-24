using KworkAndreev.Core;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AdminInfoManagmentControl.xaml
    /// </summary>
    public partial class AdminInfoManagmentControl : UserControl
    {
        public AdminInfoManagmentControl()
        {
            InitializeComponent();
        }

        private byte[] imageDB;


        private async void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbServicesName.Text) || string.IsNullOrEmpty(TbPrice.Text) || string.IsNullOrEmpty(TbServicesDescription.Text))
            {
                MessageBox.Show("Не все поля заполнены!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }    
            else
            {
                if(FrameNavigate.DB.Services.Count(u => u.ServicesName == TbServicesName.Text) > 0)
                {
                    MessageBox.Show("Такая услуга уже существует", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                FrameNavigate.DB.Services.Add(new Model.Service
                {
                    ServicesName = TbServicesName.Text,
                    ServicesPrice = TbPrice.Text,
                    ServicesImage = imageDB,
                    ServicesDescription = TbServicesDescription.Text
                });

                await FrameNavigate.DB.SaveChangesAsync();
                MessageBox.Show("Услуга успешно добавлена", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameNavigate.FrameObject.Navigate(new MainAdministratorPage());

            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
           FrameNavigate.FrameObject.Navigate(new MainAdministratorPage());
        }

        private void BtnUseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            byte[] image_bytes = File.ReadAllBytes(openFileDialog.FileName);
            Uri fileUri = new Uri(openFileDialog.FileName);
            image.Source = new BitmapImage(fileUri);
            imageDB = image_bytes;
        }
    }
}

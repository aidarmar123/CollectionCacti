using CollectionRareCacti.Models;
using CollectionRareCacti.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace CollectionRareCacti.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        User contextUser;
        public RegistrationPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }
        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = ValidationClass.ValidationLine(contextUser);
            if (error.Length == 0)
            {
                if (contextUser.Id == 0)
                    App.DB.User.Add(contextUser);
                App.DB.SaveChanges();
                App.contextUser = contextUser;
                NavigationService.Navigate(new MainPage());
            }
            else
            {
                MessageBox.Show(error.ToString());
            }
        }

       

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

using CollectionRareCacti.Pages;
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
using System.Windows.Shapes;

namespace CollectionRareCacti.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
            DataContext = App.contextUser;
        }
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new RegistrationPage(App.contextUser));
            this.Close();
        }
        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            App.DB.User.Remove(App.contextUser);
            App.DB.SaveChanges();
            App.mainFrame.Navigate(new LoginPage());
            this.Close();

        }
    }
}

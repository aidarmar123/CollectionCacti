using CollectionRareCacti.Windows;
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

namespace CollectionRareCacti.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            
            DataContext = App.contextUser;
            CollectionFrame.Navigate(new AllCactiPage());
            ShowsFrame.Navigate(new AllShowPage());
        }
        private void SpUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new ProfileWindow().ShowDialog();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new LoginPage());
        }
    }
}

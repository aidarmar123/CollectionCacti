using CollectionRareCacti.Models;
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
    /// Логика взаимодействия для AllShowPage.xaml
    /// </summary>
    public partial class AllShowPage : Page
    {
        public AllShowPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            LVShow.ItemsSource = App.DB.Show.ToList();
        }

        private void BRemoveShow_Click(object sender, RoutedEventArgs e)
        {
            if (LVShow.SelectedItem is Show show)
            {
                foreach (var item in App.DB.ShowCacti.Where(x=>x.ShowId==show.Id).ToList())
                {
                    App.DB.ShowCacti.Remove(item);
                }
                App.DB.Show.Remove(show);
                App.DB.SaveChanges();
                Refresh();
            }

        }

        private void BEditShow_Click(object sender, RoutedEventArgs e)
        {
            if(LVShow.SelectedItem is Show show)
            {
                NavigationService.Navigate(new AddShowPage(show));
            }
        }

        private void BAddShow_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddShowPage(new Show()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}

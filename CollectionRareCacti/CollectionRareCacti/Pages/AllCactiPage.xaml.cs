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
    /// Логика взаимодействия для AllCactiPage.xaml
    /// </summary>
    public partial class AllCactiPage : Page
    {
        public AllCactiPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void BAddCacti_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditCactiPage(new Cacti()));
        }

        private void BEditCacti_Click(object sender, RoutedEventArgs e)
        {
            if(LVCacti.SelectedItem is Cacti cacti)
            {
                NavigationService.Navigate(new AddEditCactiPage(cacti));

            }
        }

        private void BRemoveCacti_Click(object sender, RoutedEventArgs e)
        {
            if (LVCacti.SelectedItem is Cacti cacti)
            {

                foreach(var instraction in App.DB.Instraction.Where(x=>x.CactiId==cacti.Id).ToList())
                {
                    App.DB.Instraction.Remove(instraction);
                }

                foreach(var item in App.DB.ShowCacti.Where(x => x.CactiId == cacti.Id).ToList())
                {
                    App.DB.ShowCacti.Remove(item);
                }

                App.DB.Cacti.Remove(cacti);
                App.DB.SaveChanges();
                Refresh();
            }
        }

        private void Refresh()
        {
            LVCacti.ItemsSource = App.DB.Cacti.Where(x => x.UserId == App.contextUser.Id).ToList();
        }

       

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}

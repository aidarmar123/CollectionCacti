using CollectionRareCacti.Models;
using CollectionRareCacti.Service;
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
    /// Логика взаимодействия для AddShowPage.xaml
    /// </summary>
    public partial class AddShowPage : Page
    {
        Show contextShow;
        ShowCacti contextShowCasti = new ShowCacti();
        public AddShowPage(Models.Show show)
        {
            InitializeComponent();
            CbCasti.ItemsSource = App.DB.Cacti.ToList();
            contextShow = show;
            if (contextShow.Date == DateTime.MinValue)
                contextShow.Date = DateTime.Now;
            DataContext = contextShow;
            SPCacti.DataContext = contextShowCasti;
            


        }

        private void BAddCasti_Click(object sender, RoutedEventArgs e)
        {
            if (contextShow.Id != 0)
            {
                if (contextShowCasti.Cacti != null)
                {
                    contextShowCasti.ShowId = contextShow.Id;
                    App.DB.ShowCacti.Add(contextShowCasti);
                    App.DB.SaveChanges();
                    contextShowCasti = new ShowCacti();
                    DataContext = null;
                    DataContext = contextShow;
                    SPCacti.DataContext = null;
                    SPCacti.DataContext = contextShow;
                }
                else
                {
                    MessageBox.Show("Выберите кактус");
                }
            }
            else
            {
                MessageBox.Show("Сначала сохраните выставку");
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            var error = ValidationClass.ValidationLine(contextShow);
            if (error.Length == 0)
            {
                if (contextShow.Id == 0)
                    App.DB.Show.Add(contextShow);
                App.DB.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
            }
            else
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

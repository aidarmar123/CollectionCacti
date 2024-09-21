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
    /// Логика взаимодействия для AddEditCactiPage.xaml
    /// </summary>
    public partial class AddEditCactiPage : Page
    {
        Cacti contextCacti;
        Instraction contextInstraction = new Instraction();
        public AddEditCactiPage(Cacti cacti)
        {
            InitializeComponent();
            contextCacti = cacti;
            contextCacti.UserId=App.contextUser.Id;
            DataContext = contextCacti;
            SpInstarction.DataContext = contextInstraction;
            CbCountry.ItemsSource = App.DB.Country.ToList();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            var error = ValidationClass.ValidationLine(contextCacti);
            if (error.Length == 0)
            {
                if (contextCacti.Id == 0)
                    App.DB.Cacti.Add(contextCacti);
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

        private void BAddInstaction_Click(object sender, RoutedEventArgs e)
        {
            if (contextCacti.Id != 0)
            {
                if (!string.IsNullOrEmpty(contextInstraction.Name))
                {
                    contextInstraction.CactiId = contextCacti.Id;
                    App.DB.Instraction.Add(contextInstraction);
                    App.DB.SaveChanges();
                    contextInstraction = new Instraction();
                    DataContext = null;
                    DataContext = contextCacti;
                    SpInstarction.DataContext = null;
                    SpInstarction.DataContext = contextInstraction;
                }
                else
                {
                    MessageBox.Show("Введите пункт инструкции");
                }
            }
            else
            {
                MessageBox.Show("Сначала сохраните куктус");
            }
        }
    }
}

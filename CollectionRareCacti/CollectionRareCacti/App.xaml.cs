using CollectionRareCacti.Models;
using CollectionRareCacti.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CollectionRareCacti
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CollectionCactiEntities DB = new CollectionCactiEntities();
        public static User contextUser;
        public static Frame mainFrame;
        
        App()
        {
            RegistrProvider<User, MetaUser>();
            RegistrProvider<Cacti, MetaCacti>();
            RegistrProvider<Show, MetaShow>();
        }

        private void RegistrProvider<T, A>()
        {
            var provider = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(T), typeof(A));
            TypeDescriptor.AddProviderTransparent(provider, typeof(T));
        }

    }
}

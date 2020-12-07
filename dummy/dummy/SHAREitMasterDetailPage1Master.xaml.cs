using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dummy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SHAREitMasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public SHAREitMasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new SHAREitMasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class SHAREitMasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SHAREitMasterDetailPage1MasterMenuItem> MenuItems { get; set; }

            public SHAREitMasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<SHAREitMasterDetailPage1MasterMenuItem>(new[]
                {
                    new SHAREitMasterDetailPage1MasterMenuItem { Id = 0, Title = "Page 1" },
                    new SHAREitMasterDetailPage1MasterMenuItem { Id = 1, Title = "Page 2" },
                    new SHAREitMasterDetailPage1MasterMenuItem { Id = 2, Title = "Page 3" },
                    new SHAREitMasterDetailPage1MasterMenuItem { Id = 3, Title = "Page 4" },
                    new SHAREitMasterDetailPage1MasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
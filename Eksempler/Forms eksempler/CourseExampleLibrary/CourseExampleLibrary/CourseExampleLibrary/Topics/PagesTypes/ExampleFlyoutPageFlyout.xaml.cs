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

namespace CourseExampleLibrary.Topics.PagesTypes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public ExampleFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new ExampleFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ExampleFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ExampleFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public ExampleFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ExampleFlyoutPageFlyoutMenuItem>(new[]
                {
                    new ExampleFlyoutPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new ExampleFlyoutPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new ExampleFlyoutPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new ExampleFlyoutPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new ExampleFlyoutPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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
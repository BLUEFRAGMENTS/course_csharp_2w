using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.Maps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
        }

        private async void OpenMapClicked(object sender, EventArgs e)
        {
            var location = new Location()
            {
                Latitude = 55.676098,
                Longitude = 12.568337,
            };

            var mapLaunchOptions = new MapLaunchOptions()
            {
                 NavigationMode = NavigationMode.Default,
            };

            await Map.OpenAsync(location, mapLaunchOptions);
        }
    }
}
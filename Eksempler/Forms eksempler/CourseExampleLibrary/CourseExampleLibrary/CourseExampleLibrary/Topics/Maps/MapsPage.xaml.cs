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
            var locales = await TextToSpeech.GetLocalesAsync();

            ////await Map.OpenAsync("Test");

            await TextToSpeech.SpeakAsync("Hello!");
        }
    }
}
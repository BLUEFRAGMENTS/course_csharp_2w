using CourseExampleLibrary.Utilities;
using System;
using System.Globalization;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.SwitchLanguage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchLanguagePage : ContentPage
    {
        public SwitchLanguagePage()
        {
            InitializeComponent();

            Title = "Switch language";

            cultureLabel.Text = Thread.CurrentThread.CurrentCulture.Name;
            text01Label.Text = AppResources.TestText01;

            cultureLabel.BackgroundColor = ColorFactory.GenerateRandomColor();
            text01Label.BackgroundColor = ColorFactory.GenerateRandomColor();
        }

        private void SwitchToEnglishButtonClicked(object sender, EventArgs e)
        {
            SkiftKultur("en-US");
        }

        private void SwitchToDanishButtonClicked(object sender, EventArgs e)
        {
            SkiftKultur("da-DK");
        }

        private async void GoToSimilarPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchLanguagePage());
        }

        private void SkiftKultur(string culture)
        {
            ((App)App.Current).LanugageService.ChangeLanguage(culture);
        }
    }
}
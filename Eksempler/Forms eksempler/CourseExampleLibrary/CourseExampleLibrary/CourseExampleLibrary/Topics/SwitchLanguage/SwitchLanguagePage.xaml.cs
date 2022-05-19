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

            UpdateTexts();

            currentCultureLabel.BackgroundColor = ColorFactory.GenerateRandomColor();
            cultureLabel.BackgroundColor = ColorFactory.GenerateRandomColor();
            text01Label.BackgroundColor = ColorFactory.GenerateRandomColor();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            UpdateCurretCultureLabel();
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

        private void UpdateTextsButtonClicked(object sender, EventArgs e)
        {
            UpdateTexts();
        }

        private void SkiftKultur(string culture)
        {
            if (App.Current is App app)
            {
                app.LanugageService.ChangeLanguage(culture);
                UpdateCurretCultureLabel();
            }
        }

        private void UpdateCurretCultureLabel()
        {
            currentCultureLabel.Text = "Current culture: " + Thread.CurrentThread.CurrentCulture.Name;
        }

        private void UpdateTexts()
        {
            cultureLabel.Text = "Lanugage used when reading: " + Thread.CurrentThread.CurrentCulture.Name;
            text01Label.Text = "Tekst: " + AppResources.TestText01;
        }
    }
}
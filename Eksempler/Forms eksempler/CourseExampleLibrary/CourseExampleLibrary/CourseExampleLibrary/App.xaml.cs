using CourseExampleLibrary.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary
{
    public partial class App : Application
    {
        public ILanguageService LanugageService { get; set; }

        public App()
        {
            InitializeComponent();

            var startPage = new MainPage();
            var navigationPage = new NavigationPage(startPage);
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

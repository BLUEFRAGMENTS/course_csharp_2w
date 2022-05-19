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
            MainPage = new NavigationPage(startPage);
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

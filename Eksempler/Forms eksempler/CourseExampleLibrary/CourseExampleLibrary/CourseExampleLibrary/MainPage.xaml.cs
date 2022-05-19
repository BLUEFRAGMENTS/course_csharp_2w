using CourseExampleLibrary.Topics.CollectionView;
using CourseExampleLibrary.Topics.PagesTypes;
using CourseExampleLibrary.Topics.ReusableControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CourseExampleLibrary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Start page";

            Console.WriteLine("Started Console");
            System.Diagnostics.Debug.WriteLine("Started debug");

            AddHeader("Go to controls:");
            AddNewPageButton(new ResuableControlsPage(), "Reuse controls");
            AddNewPageButton(new CollectionViewPage(), "CollectionView");

            AddHeader("Switch main page to:");
            AddChangeMainPageButton(new ExampleFlyoutPage(), "Flyout page [Not working for UWP out of the box]");
        }

        private void AddNewPageButton(Page page, string text)
        {
            var button = new Button();
            button.Text = text;
            button.Command = new Command(() => Navigation.PushAsync(page));
            mainStackLayout.Children.Add(button);
        }

        private void AddChangeMainPageButton(Page page, string text)
        {
            var button = new Button();
            button.Text = text;
            button.Command = new Command(() => App.Current.MainPage = page);
            mainStackLayout.Children.Add(button);
        }

        private void AddHeader(string text)
        {
            var headerLabel = new Label();
            headerLabel.FontSize = 24;
            headerLabel.Text = text;
            mainStackLayout.Children.Add(headerLabel);
        }
    }
}

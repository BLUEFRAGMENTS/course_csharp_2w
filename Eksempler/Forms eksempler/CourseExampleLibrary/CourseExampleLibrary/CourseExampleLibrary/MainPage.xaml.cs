using CourseExampleLibrary.Topics.CollectionView;
using CourseExampleLibrary.Topics.MVVM;
using CourseExampleLibrary.Topics.MVVM.List_MVVM;
using CourseExampleLibrary.Topics.PagesTypes;
using CourseExampleLibrary.Topics.ReusableControl;
using CourseExampleLibrary.Topics.SwitchLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

            CreateControlsButtons();
            CreateChangePageButtons();
        }

        private void CreateControlsButtons()
        {
            AddHeader("Go to controls:");

            var reuseButton = AddNewPageButton("Reuse controls");
            reuseButton.Command = new Command(() => Navigation.PushAsync(new ResuableControlsPage()));

            var collectionViewButton = AddNewPageButton("CollectionView");
            collectionViewButton.Command = new Command(() => Navigation.PushAsync(new CollectionViewPage()));

            var switchLanguageButton = AddNewPageButton("Switch Language");
            switchLanguageButton.Command = new Command(() => Navigation.PushAsync(new SwitchLanguagePage()));

            var mvvmPageButton = AddNewPageButton("Basic MVVM page");
            mvvmPageButton.Command = new Command(() => Navigation.PushAsync(new MvvmExamplePage()));

            var listMvvmPageButton = AddNewPageButton("List MVVM page + Converters");
            listMvvmPageButton.Command = new Command(() => Navigation.PushAsync(new ListMvvmPage()));
        }

        private void CreateChangePageButtons()
        {
            AddHeader("Switch main page to:");
            AddChangeMainPageButton(new ExampleFlyoutPage(), "Flyout page [Not working for UWP out of the box]");
        }

        private Button AddNewPageButton(string text)
        {
            var button = new Button();
            button.Text = text;
            mainStackLayout.Children.Add(button);
            return button;
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

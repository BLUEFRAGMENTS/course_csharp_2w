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

            AddNewPageButton(new ResuableControlsPage(), "Reuse controls");
        }

        private void AddNewPageButton(Page page, string text)
        {
            var button = new Button();
            button.Text = text;
            button.Command = new Command(() => Navigation.PushAsync(page));
            mainStackLayout.Children.Add(button);
        }
    }
}

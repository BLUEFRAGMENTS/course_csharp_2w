using CourseExampleLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MvvmExamplePage : ContentPage
    {
        public MvvmExamplePage()
        {
            InitializeComponent();

            ColorFactory.ApplyBackgroundColorsToStack(rootStackLayout);

            // Set the binding context, so we can bind to the viewmodel in xaml.
            BindingContext = new MvvmExamplePageViewModel();
        }
    }
}
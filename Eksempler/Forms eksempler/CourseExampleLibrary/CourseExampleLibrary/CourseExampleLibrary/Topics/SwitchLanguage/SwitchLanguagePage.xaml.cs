using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            minLabel.Text = AppResources.TestText01;
        }
    }
}
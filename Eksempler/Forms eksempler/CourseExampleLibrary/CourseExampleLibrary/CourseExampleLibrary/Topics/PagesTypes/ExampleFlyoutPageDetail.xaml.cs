using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.PagesTypes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleFlyoutPageDetail : ContentPage
    {
        public ExampleFlyoutPageDetail()
        {
            InitializeComponent();
        }

        public string TextNavigationParamter { get; set; }
    }
}
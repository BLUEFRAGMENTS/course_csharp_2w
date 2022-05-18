using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.ReusableControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResuableControlsPage : ContentPage
    {
        public int MyInt { get; set; }

        public ResuableControlsPage()
        {
            InitializeComponent();

            Title = "Reusing controls";
        }
    }
}
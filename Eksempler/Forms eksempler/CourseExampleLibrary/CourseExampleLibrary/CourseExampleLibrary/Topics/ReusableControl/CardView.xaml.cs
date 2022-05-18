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
    public partial class CardView : ContentView
    {
        public CardView()
        {
            InitializeComponent();
        }

        public string CardText
        {
            get => cardLabel.Text;
            set => cardLabel.Text = value;
        }

        public ImageSource CardSource
        {
            get => cardImage.Source;
            set => cardImage.Source = value;
        }
    }
}
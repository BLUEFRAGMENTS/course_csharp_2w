using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.MVVM.BindableProperties_MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindablePropertiesPage : ContentPage
    {
        private int _dkDeltaHours;
        private int _usDeltaHours;

        public BindablePropertiesPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public int DKDeltaHours
        {
            get => _dkDeltaHours;
            private set
            {
                _dkDeltaHours = value;
                OnPropertyChanged(nameof(DKDeltaHours));
            }
        }

        public int USDeltaHours
        {
            get => _usDeltaHours;
            private set
            {
                _usDeltaHours = value;
                OnPropertyChanged(nameof(USDeltaHours));
            }
        }

        private void OnAdaptTimeButtonClicked(object sender, EventArgs e)
        {
            DKDeltaHours = -1;
            USDeltaHours = 9;
        }

        private void TurnEarthAnHourButtonClicked(object sender, EventArgs e)
        {
            DKDeltaHours++;
            USDeltaHours++;
        }
    }
}
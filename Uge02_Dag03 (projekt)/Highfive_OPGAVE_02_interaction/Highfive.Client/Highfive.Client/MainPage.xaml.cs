using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Highfive.Client
{
    public partial class MainPage : ContentPage
    {
        private bool _isHighfiveInProgress;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void HighfiveButtonClicked(object sender, EventArgs e)
        {
            if (_isHighfiveInProgress == false)
            {
                statusLabel.Text = "Highfive igang...";
                _isHighfiveInProgress = true;

                await Task.Delay(5000);

                if (_isHighfiveInProgress)
                {
                    GotLeftHanging();
                }
            }
        }

        private void FakeSuccessClicked(object sender, EventArgs e)
        {
            if (_isHighfiveInProgress)
            {
                GotAHighfive();
            }
        }

        private void GotAHighfive()
        {
            statusLabel.Text = "Highfive! Ka-poow!";
            _isHighfiveInProgress = false;
        }

        private void GotLeftHanging()
        {
            statusLabel.Text = "Du bliv efterladt hængende...";
            _isHighfiveInProgress = false;
        }
    }
}

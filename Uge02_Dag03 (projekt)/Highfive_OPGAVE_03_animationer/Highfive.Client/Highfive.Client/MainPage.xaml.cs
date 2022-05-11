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

                // Animer highfive suspense
                var scaleTask = highfiveButton.ScaleTo(0.1, 10_000, Easing.SinOut);
                var translateTask = highfiveButton.TranslateTo(-30, 0, 1000, Easing.SinOut);
                var rotateTask = highfiveButton.RotateTo(-20, 1_000, Easing.SinOut);
                await Task.WhenAll(scaleTask, translateTask, rotateTask);

                if (_isHighfiveInProgress)
                {
                    await GotLeftHangingAsync();
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

            ViewExtensions.CancelAnimations(highfiveButton);

            // Ingen animation... Så hurtigt går det!
            highfiveButton.Scale = 1;
            highfiveButton.TranslationX = 0;
            highfiveButton.Rotation = 0;
        }

        private async Task GotLeftHangingAsync()
        {
            statusLabel.Text = "Du bliv efterladt hængende...";

            // Animer tilbage
            var scaleTask = highfiveButton.ScaleTo(1.0, 1000, Easing.SinOut);
            var translateTask = highfiveButton.TranslateTo(0, 0, 1000, Easing.SinOut);
            var rotateTask = highfiveButton.RotateTo(0, 1000, Easing.SinOut);
            await Task.WhenAll(scaleTask, translateTask, rotateTask);

            _isHighfiveInProgress = false;
        }
    }
}

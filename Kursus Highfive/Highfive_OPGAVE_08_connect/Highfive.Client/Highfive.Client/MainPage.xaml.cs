using Highfive.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Highfive.Client
{
    public partial class MainPage : ContentPage
    {
        private readonly StorageService _storageService;
        private bool _isHighfiveInProgress;

        public MainPage()
        {
            InitializeComponent();

            _storageService = new StorageService();
            brugerNavnEntry.Text = _storageService.RetrieveUsernameIfAny();
        }

        private async void HighfiveButtonClicked(object sender, EventArgs e)
        {
            if (_isHighfiveInProgress == false)
            {
                // Validering
                if (string.IsNullOrEmpty(brugerNavnEntry.Text))
                {
                    await DisplayAlert(
                        "Intet brugernavn!",
                        "Intet brugernavn... intet highfive...",
                        "ok");

                    return;
                }

                statusLabel.Text = "Highfive igang...";
                _isHighfiveInProgress = true;

                // Animer highfive suspense
                var scaleTask = highfiveButton.ScaleTo(0.1, 10_000, Easing.SinOut);
                var translateTask = highfiveButton.TranslateTo(-30, 0, 1000, Easing.SinOut);
                var rotateTask = highfiveButton.RotateTo(-20, 1_000, Easing.SinOut);

                // Fire and forget method
                Task.Run(async () => await Task.WhenAll(scaleTask, translateTask, rotateTask)).ConfigureAwait(false);

                var highfiveResult = await SendHighfiveAsync();
                if (highfiveResult?.HighfivePerson2 != null)
                {
                    GotAHighfive(highfiveResult);
                }
                else
                {
                    await GotLeftHangingAsync();
                }
            }
        }

        private void GotAHighfive(HighfiveResult highfiveResult)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var navn1 = highfiveResult?.HighfivePerson1?.Name;
                var navn2 = highfiveResult?.HighfivePerson2?.Name;
                statusLabel.Text = $"{navn1} highfivede med {navn2}";
                _isHighfiveInProgress = false;

                ViewExtensions.CancelAnimations(highfiveButton);

                // Ingen animation... Så hurtigt går det!
                highfiveButton.Scale = 1;
                highfiveButton.TranslationX = 0;
                highfiveButton.Rotation = 0;
            });
        }

        private async Task GotLeftHangingAsync()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                statusLabel.Text = "Du bliv efterladt hængende...";
            });

            // Animer tilbage
            var scaleTask = highfiveButton.ScaleTo(1.0, 1000, Easing.SinOut);
            var translateTask = highfiveButton.TranslateTo(0, 0, 1000, Easing.SinOut);
            var rotateTask = highfiveButton.RotateTo(0, 1000, Easing.SinOut);
            await Task.WhenAll(scaleTask, translateTask, rotateTask);

            _isHighfiveInProgress = false;
        }

        private void BrugerNavnEntryUnfocused(object sender, FocusEventArgs e)
        {
            _storageService.StoreUsername(brugerNavnEntry.Text);
        }

        private async Task<HighfiveResult> SendHighfiveAsync()
        {
            try
            {
                var requestUri = $"http://localhost:5211/api/Highfive";
                var httpClient = new HttpClient();

                var highfivePerson = new HighfivePerson()
                {
                    Id = Guid.NewGuid(),
                    Name = brugerNavnEntry.Text,
                };

                var highfivePersonAsJson = JsonConvert.SerializeObject(highfivePerson);
                var stringContent = new StringContent(highfivePersonAsJson, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(requestUri, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var contentAsJson = await response.Content.ReadAsStringAsync();
                    var highfiveResult = JsonConvert.DeserializeObject<HighfiveResult>(contentAsJson);
                    return highfiveResult;
                }
            }
            catch (Exception ex)
            {
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }

                System.Diagnostics.Debug.WriteLine("Der skete en fejl: " + ex.Message);
            }

            return null;
        }
    }
}

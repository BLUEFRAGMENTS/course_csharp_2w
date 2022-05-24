using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsPage : ContentPage
    {
        private string _moneyAsText;
        private decimal _money;

        public ControlsPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public string MoneyAsText
        {
            get => _moneyAsText;
            set
            {
                if (_moneyAsText != value)
                {
                    _moneyAsText = value;
                    OnPropertyChanged(nameof(MoneyAsText));

                    // Validering
                    // Try parse
                    var convertedMoneyAsText = _moneyAsText.Replace(',', '.');

                    var didParse = decimal.TryParse(convertedMoneyAsText, out decimal money);
                    if (didParse)
                    {
                        Money = money;
                    }
                    else
                    {
                        Money = -1;
                    }
                }
            }
        }

        public decimal Money
        {
            get => _money;
            set
            {
                if (_money != value)
                {
                    _money = value;
                    OnPropertyChanged(nameof(Money));
                }
            }
        }
    }
}
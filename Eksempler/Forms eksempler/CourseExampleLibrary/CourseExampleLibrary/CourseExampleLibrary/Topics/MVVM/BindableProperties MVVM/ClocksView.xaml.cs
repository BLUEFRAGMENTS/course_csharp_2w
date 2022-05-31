using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.MVVM.BindableProperties_MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClocksView : ContentView
    {
        public static readonly BindableProperty TimeDifferenceInHoursProperty =
            BindableProperty.Create(
               nameof(TimeDifferenceInHours),
               typeof(int),
               typeof(ClocksView),
               0);

        private Timer timer;

        public ClocksView()
        {
            InitializeComponent();

            timer = new Timer(200);
            timer.Start();
        }

        /// <summary>
        /// Lifecycles are added from the pages, since there are no built-in.
        /// </summary>
        public void Load()
        {
            timer.Elapsed += OnTimeElapsed;
        }

        /// <summary>
        /// Lifecycles are added from the pages, since there are no built-in.
        /// </summary>
        public void Unload()
        {
            timer.Elapsed -= OnTimeElapsed;
        }

        private void OnTimeElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateTimeLabel();
        }

        public int TimeDifferenceInHours
        {
            get => (int)GetValue(TimeDifferenceInHoursProperty);
            set => SetValue(TimeDifferenceInHoursProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(TimeDifferenceInHours))
            {
                hoursLabel.Text = $"({TimeDifferenceInHours}) [Updated={DateTime.UtcNow.ToString("HH:mm:ss")}]";
            }
        }

        private void UpdateTimeLabel()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                this.timeLabel.Text = DateTime.UtcNow.AddHours(TimeDifferenceInHours).ToString("HH:mm:ss");
            });
        }
    }
}
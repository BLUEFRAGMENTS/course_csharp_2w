using Xamarin.Forms;

namespace CourseExampleLibrary.Topics.MVVM
{
    public class MvvmExamplePageViewModel : ViewModelBase
    {
        private string _entryText;
        private string _labelText;
        private int _buttonPressedCount;

        public MvvmExamplePageViewModel()
        {
            ButtonPressedCommand = new Command(ButtonPressed);
            ButtonPressedIfConditionIsOKCommand = new Command(ButtonPressed, CanPressButton);
        }

        public Command ButtonPressedCommand { get; }

        public Command ButtonPressedIfConditionIsOKCommand { get; }

        public string EntryText
        {
            get
            {
                return _entryText;
            }

            set
            {
                if (_entryText != value)
                {
                    _entryText = value;
                    OnPropertyChanged(nameof(EntryText));

                    // Update LabelText
                    LabelText = _entryText;

                    // Evaluate if button can be pressed
                    ButtonPressedIfConditionIsOKCommand.ChangeCanExecute();
                }
            }
        }

        public string LabelText
        {
            get
            {
                return _labelText;
            }

            set
            {
                if (_labelText != value)
                {
                    _labelText = value;
                    OnPropertyChanged(nameof(LabelText));
                }
            }
        }

        public int ButtonPressedCount
        {
            get
            {
                return _buttonPressedCount;
            }

            set
            {
                if (_buttonPressedCount != value)
                {
                    _buttonPressedCount = value;
                    OnPropertyChanged(nameof(ButtonPressedCount));
                }
            }
        }

        private bool CanPressButton(object arg)
        {
            return string.IsNullOrEmpty(EntryText) == false;
        }

        private void ButtonPressed(object obj)
        {
            ButtonPressedCount++;
        }
    }
}

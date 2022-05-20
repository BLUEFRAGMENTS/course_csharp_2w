using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseExampleLibrary.Topics.MVVM.List_MVVM
{
    public class AnimalItemViewModel : ViewModelBase
    {
        private readonly AnimalItem _animalItem;

        private string _statusText = "Alive!";
        private bool _isExtinct;

        public AnimalItemViewModel(AnimalItem animalItem)
        {
            _animalItem = animalItem;

            Name = animalItem.Name;
            IsExtinct = animalItem.IsExtinct;

            StartExtinction();
        }

        public string Name { get; set; }

        public string StatusText
        {
            get => _statusText;
            set
            {
                if (_statusText != value)
                {
                    _statusText = value;
                    OnPropertyChanged(nameof(StatusText));
                }
            }
        }

        public bool IsExtinct
        {
            get => _isExtinct;
            set
            {
                if (_isExtinct != value)
                {
                    _isExtinct = value;
                    OnPropertyChanged(nameof(IsExtinct));
                }
            }
        }

        private async void StartExtinction()
        {
            var randomTimeToExistinctInMs = new Random().Next(1000, 10_000);
            await Task.Delay(randomTimeToExistinctInMs);

            IsExtinct = true;
            StatusText = "Extinct!";
        }
    }
}

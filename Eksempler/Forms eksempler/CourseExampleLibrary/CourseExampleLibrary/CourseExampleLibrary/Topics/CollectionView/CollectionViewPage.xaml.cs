using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.CollectionView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : ContentPage
    {
        private CollectionViewLayouts _currentLayout = CollectionViewLayouts.VerticalList;

        // Observable collections updates the list when "Adding" and "Removing", where a normal list needs to be assigned to the collectionview if changing.
        private ObservableCollection<KursistItem> _kursister = new ObservableCollection<KursistItem>();

        public CollectionViewPage()
        {
            InitializeComponent();

            SetStartsItems();
        }

        private void SetStartsItems()
        {
            _kursister.Add(new KursistItem() { Name = "Flemming", Alder = 42 });
            _kursister.Add(new KursistItem() { Name = "Henning", Alder = 24 });
            _kursister.Add(new KursistItem() { Name = "Lemming", Alder = 22 });

            myVerticalCollectionView.ItemsSource = _kursister;
            myHorizontalCollectionView.ItemsSource = _kursister;
            myGridVerticalCollectionView.ItemsSource = _kursister;
            myGridHorizontalCollectionView.ItemsSource = _kursister;
            UpdateInfo();
        }

        private void RemoveItemButtonClicked(object sender, EventArgs e)
        {
            if (_kursister.Any() == true)
            {
                var lastIndex = _kursister.Count - 1;
                _kursister.RemoveAt(lastIndex);
            }

            UpdateInfo();
        }

        private void AddItemButtonClicked(object sender, EventArgs e)
        {
            var alder = new Random().Next(0, 100);
            var namePostfix = new Random().Next(0, 100_000);
            var nyKursist = new KursistItem()
            {
                Name = $"Anonym ({namePostfix})",
                Alder = alder,
            };

            _kursister.Add(nyKursist);
            UpdateInfo();
        }

        private void ChangeCollectionButtonClickedView(object sender, EventArgs e)
        {
            VerticalListGrid.IsVisible = false;
            myHorizontalCollectionView.IsVisible = false;
            myGridVerticalCollectionView.IsVisible = false;
            myGridHorizontalCollectionView.IsVisible = false;

            switch (_currentLayout)
            {
                case CollectionViewLayouts.VerticalList:
                    _currentLayout = CollectionViewLayouts.HorizontalList;
                    myHorizontalCollectionView.IsVisible = true;
                    break;

                case CollectionViewLayouts.HorizontalList:
                    _currentLayout = CollectionViewLayouts.GridVertical;
                    myGridVerticalCollectionView.IsVisible = true;
                    break;

                case CollectionViewLayouts.GridVertical:
                    _currentLayout = CollectionViewLayouts.GridHorizontal;
                    myGridHorizontalCollectionView.IsVisible = true;
                    break;

                case CollectionViewLayouts.GridHorizontal:
                    _currentLayout = CollectionViewLayouts.VerticalList;
                    VerticalListGrid.IsVisible = true;
                    break;
            }

            UpdateInfo();
        }

        private void UpdateInfo()
        {
            infoLabel.Text = $"Elementer={_kursister.Count}, Layout={_currentLayout}";
        }

        private enum CollectionViewLayouts
        {
            VerticalList,
            HorizontalList,
            GridHorizontal,
            GridVertical,
        }

        private async void VerticalListItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var singleSelection = e.CurrentSelection?.FirstOrDefault();
            if (singleSelection == null)
            {
                return;
            }

            if (singleSelection is KursistItem kursistItem)
            {
                await DisplayAlert(
                    "You selected an item",
                    $"Item={kursistItem.Name}",
                    "ok");
            }
            else
            {
                await DisplayAlert(
                    "Unknown item",
                    $"The item is not a {nameof(KursistItem)}",
                    "ok");
            }

            // Reset selectedItem, so we can press the same item again.
            if (sender is Xamarin.Forms.CollectionView currentCollectionView)
            {
                currentCollectionView.SelectedItem = null;
            }
        }
    }
}
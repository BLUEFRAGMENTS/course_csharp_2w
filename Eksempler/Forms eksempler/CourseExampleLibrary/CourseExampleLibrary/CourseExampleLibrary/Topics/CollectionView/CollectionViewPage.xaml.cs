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
        // Observable collections updates the list when "Adding" and "Removing", where a normal list needs to be assigned to the collectionview if changing.
        private ObservableCollection<KursistItem> _kursister = new ObservableCollection<KursistItem>();

        private CollectionViewLayouts _currentLayout = CollectionViewLayouts.VerticalList;

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

            myCollectionView.ItemsSource = _kursister;
            UpdateInfo();
        }

        private void RemoveItemButtonClicked(object sender, EventArgs e)
        {
            if (_kursister.Any() == true)
            {
                var lastIndex = _kursister.Count - 1;
                _kursister.RemoveAt(lastIndex);
            }
        }

        private void AddItemButtonClicked(object sender, EventArgs e)
        {
            var alder = new Random().Next(0, 100);
            var nyKursist = new KursistItem()
            {
                Name = $"Anonym ({Guid.NewGuid()})",
                Alder = alder,
            };

            _kursister.Add(nyKursist);
        }

        private void ChangeCollectionButtonClickedView(object sender, EventArgs e)
        {
            switch(_currentLayout)
            {
                case CollectionViewLayouts.VerticalList:
                    // Make into horizontal
                    myCollectionView.ItemsLayout = LinearItemsLayout.Horizontal;
                    _currentLayout = CollectionViewLayouts.HorizontalList;
                    break;

                case CollectionViewLayouts.HorizontalList:
                    // Make into gridVertical
                    myCollectionView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Vertical);
                    _currentLayout = CollectionViewLayouts.GridVertical;
                    break;

                case CollectionViewLayouts.GridVertical:
                    // Make into gridHorizontal
                    myCollectionView.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Horizontal);
                    _currentLayout = CollectionViewLayouts.GridHorizontal;
                    break;

                case CollectionViewLayouts.GridHorizontal:
                    // Make into vertical
                    myCollectionView.ItemsLayout = LinearItemsLayout.Vertical;
                    _currentLayout = CollectionViewLayouts.VerticalList;
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
    }
}
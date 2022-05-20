using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseExampleLibrary.Topics.MVVM.List_MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListMvvmPage : ContentPage
    {
        public ListMvvmPage()
        {
            InitializeComponent();

            var models = CreateDummyData();
            var viewModels = models.Select(x => new AnimalItemViewModel(x));
            myListView.ItemsSource = viewModels;
        }

        private List<AnimalItem> CreateDummyData()
        {
            var list = new List<AnimalItem>();
            list.Add(new AnimalItem("Chimpanse"));
            list.Add(new AnimalItem("Parrot"));
            list.Add(new AnimalItem("Dog"));
            list.Add(new AnimalItem("Krokodile"));
            list.Add(new AnimalItem("Cat"));
            list.Add(new AnimalItem("Elephant"));

            return list;
        }
    }
}
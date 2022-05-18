using CourseExampleLibrary.Utilities;
using Xamarin.Forms;

namespace CourseExampleLibrary.Topics.CollectionView
{
    internal class RandomColorGrid : Grid
    {
        public RandomColorGrid()
        {
            BackgroundColor = ColorFactory.GenerateRandomColor();
        }
    }
}

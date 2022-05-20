using CourseExampleLibrary.Utilities;
using Xamarin.Forms;

namespace CourseExampleLibrary.Controls
{
    internal class RandomColorGrid : Grid
    {
        public RandomColorGrid()
        {
            BackgroundColor = ColorFactory.GenerateRandomColor();
        }
    }
}

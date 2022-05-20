using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CourseExampleLibrary.Utilities
{
    internal static class ColorFactory
    {
        public static Color GenerateRandomColor()
        {
            return new Color(
                GetColorDouble(),
                GetColorDouble(),
                GetColorDouble());
        }

        private static double GetColorDouble()
        {
            var doubleBetween0And1 = new Random().NextDouble();
            var lightColorValue = (doubleBetween0And1 * 0.5) + 0.5;
            return lightColorValue;
        }

        public static void ApplyBackgroundColorsToStack(StackLayout stackLayot)
        {
            foreach (var child in stackLayot.Children)
            {
                child.BackgroundColor = GenerateRandomColor();
            }
        }
    }
}

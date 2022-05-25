using System;
using System.Collections.Generic;
using System.Text;

namespace CourseExampleLibrary.Utilities
{
    public class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Minus(double minusFrom, double minusWith)
        {
            return minusFrom - minusWith;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2 + 1;
        }
    }
}

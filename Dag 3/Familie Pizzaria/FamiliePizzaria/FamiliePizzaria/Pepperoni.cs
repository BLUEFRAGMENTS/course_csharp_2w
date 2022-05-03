using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal class Pepperoni : PizzaBase
    {
        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string ingredienser = "Pepperoni ingredienser: ";
            ingredienser += TilføjGrundTopping();
            ingredienser += ", Pepperoni";
            Console.WriteLine(ingredienser);
        }
    }
}

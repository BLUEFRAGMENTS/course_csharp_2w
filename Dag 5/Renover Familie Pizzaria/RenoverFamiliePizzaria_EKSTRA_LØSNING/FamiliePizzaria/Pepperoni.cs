using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal class Pepperoni : KødPizzaBase
    {
        public Pepperoni(bool erPizzaBlanko)
            : base(erPizzaBlanko)
        {
        }

        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string ingredienser = "Pepperoni ingredienser: ";
            ingredienser += TilføjGrundTopping();
            ingredienser += ", ";
            ingredienser += TilføjPepperoni();
            Console.WriteLine(ingredienser);
        }
    }
}

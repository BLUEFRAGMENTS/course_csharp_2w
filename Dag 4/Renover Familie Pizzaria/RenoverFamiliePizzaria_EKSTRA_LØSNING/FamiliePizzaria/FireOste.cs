using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal class FireOste : PizzaBase
    {
        public FireOste(bool erPizzaBlanko)
            : base(erPizzaBlanko)
        {
        }

        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string ingredienser = "FireOste ingredienser: ";
            ingredienser += TilføjGrundTopping();
            ingredienser += ", ";
            ingredienser += "ost, ost og ost";
            Console.WriteLine(ingredienser);
        }
    }
}

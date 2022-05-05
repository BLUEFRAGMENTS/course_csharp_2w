using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal class Hawaii : PizzaBase
    {
        public Hawaii(bool erPizzaBlanko)
            : base(erPizzaBlanko)
        {
        }

        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string ingredienser = "Hawaii ingredienser: ";
            ingredienser += TilføjGrundTopping();
            ingredienser += ", Skinke og Ananas";
            Console.WriteLine(ingredienser);
        }
    }
}

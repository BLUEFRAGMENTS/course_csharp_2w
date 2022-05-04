using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal class Hawaii : KødPizzaBase
    {
        public Hawaii(bool erPizzaBlanko)
            : base(erPizzaBlanko)
        {
        }

        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string ingredienser = "Hawaii ingredienser: ";
            ingredienser += TilføjGrundTopping();
            ingredienser += ", ";
            ingredienser += TilføjSkinke();
            ingredienser += ", ";
            ingredienser += "Ananas";
            Console.WriteLine(ingredienser);
        }
    }
}

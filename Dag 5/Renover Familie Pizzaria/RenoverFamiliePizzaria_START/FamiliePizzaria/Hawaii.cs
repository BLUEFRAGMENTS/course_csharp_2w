using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    public class Hawaii : PizzaBase
    {
        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string ingredienser = "Hawaii ingredienser: ";
            ingredienser += TilføjGrundTopping();
            ingredienser += ", Skinke og Ananas";
            Console.WriteLine(ingredienser);
        }
    }
}

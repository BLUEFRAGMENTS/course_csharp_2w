using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal class Pepperoni : PizzaBase
    {
        public Pepperoni(bool erPizzaBlanko)
            : base(erPizzaBlanko)
        {
        }

        protected override bool MedDressing => true;

        protected override bool MedChili => true;

        protected override string FåNavnPåPizza()
        {
            return "Pepperoni pizza (nr1)";
        }

        protected override string FåPizzaIngredienser()
        {
            return "Pepperoni";
        }
    }
}

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

        protected override string FåNavnPåPizza()
        {
            return "Hawaii pizza (nr2)";
        }

        protected override string FåPizzaIngredienser()
        {
            return "Skinke og Ananas";
        }
    }
}

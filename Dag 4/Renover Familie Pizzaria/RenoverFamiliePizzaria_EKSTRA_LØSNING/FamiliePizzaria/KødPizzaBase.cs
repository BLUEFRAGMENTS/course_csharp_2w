using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    internal abstract class KødPizzaBase : PizzaBase
    {
        public KødPizzaBase(bool erPizzaBlanko)
            : base(erPizzaBlanko)
        {
        }

        protected string TilføjPepperoni()
        {
            return "Pepperoni";
        }

        protected string TilføjSkinke()
        {
            return "Skinke";
        }
    }
}

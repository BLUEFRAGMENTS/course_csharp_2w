using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliePizzaria
{
    // TRIN 1
    internal abstract class PizzaBase
    {
        private bool _erPizzaBlanko;

        public PizzaBase(bool erPizzaBlanko)
        {
            _erPizzaBlanko = erPizzaBlanko;
        }

        public void SkrivPizzaBeskrivelseIKonsollen()
        {
            string beskrivelse = FåNavnPåPizza();
            beskrivelse += ", ";
            beskrivelse += TilføjGrundTopping();
            beskrivelse += ", ";
            beskrivelse += FåPizzaIngredienser();

            Console.WriteLine(beskrivelse);
        }

        private string TilføjGrundTopping()
        {
            if (_erPizzaBlanko)
            {
                return "Ost";
            }
            else
            {
                return "Ost og Tomatsovs";
            }
        }

        protected abstract string FåNavnPåPizza();

        protected virtual string FåPizzaIngredienser()
        {
            return "Ikke nogen ingredienser";
        }
    }
}

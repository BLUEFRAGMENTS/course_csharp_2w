using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorJournalen
{
    internal class Hånd
    {
        private DoktorJournal _journal = new DoktorJournal();

        public void TjekFingre()
        {
            _journal.Kritisk("Fingre mangler!");
        }

        public void TjekHåndflade()
        {
            _journal.OK("Håndflade");
        }
    }
}

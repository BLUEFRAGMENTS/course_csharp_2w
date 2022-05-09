using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorJournalen
{
    internal class Fod : KropsdelBase
    {
        private DoktorJournal<Fod> _journal = new DoktorJournal<Fod>();

        public void CheckHæl()
        {
            _journal.Dårligt("Hæl slidt");
        }

        public void CheckTæer()
        {
            _journal.OK("11 Tæer er bedre end 10 Tæer!");
        }
    }
}

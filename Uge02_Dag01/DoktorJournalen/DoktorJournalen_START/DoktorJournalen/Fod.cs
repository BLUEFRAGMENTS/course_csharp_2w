using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorJournalen
{
    internal class Fod
    {
        private DoktorJournal _journal = new DoktorJournal();

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

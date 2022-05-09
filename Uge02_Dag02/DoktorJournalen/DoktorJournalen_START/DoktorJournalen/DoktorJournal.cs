using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoktorJournalen
{
    internal class DoktorJournal
    {
        public void OK(string tekst)
        {
            Log("OK", tekst);
        }

        public void Dårligt(string tekst)
        {
            Log("Dårligt", tekst);
        }

        public void Kritisk(string tekst)
        {
            Log("Kritisk", tekst);
        }

        private void Log(string status, string tekst)
        {
            Console.WriteLine($"({status}) {tekst}");
        }
    }
}

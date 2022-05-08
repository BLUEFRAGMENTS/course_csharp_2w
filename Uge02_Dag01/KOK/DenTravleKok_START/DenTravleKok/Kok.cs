using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenTravleKok
{
    internal class Kok
    {
        private void WriteLineMedTid(string tekst)
        {
            string tidsStempel = DateTime.Now.ToString("HH:mm:ss:fff");
            Console.WriteLine($"[{tidsStempel}] {tekst}");
        }
    }
}

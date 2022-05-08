using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenTravleKok
{
    internal class Kok
    {
        public async Task DrikKaffeAsync()
        {
            WriteLineMedTid("Kaffe: start");
            await Task.Delay(100);
            WriteLineMedTid("Kaffe: slut");
        }

        public async Task<string> HakGrøntsagerAsync()
        {
            WriteLineMedTid("Hak grøntsager: start");
            await Task.Delay(2000);
            WriteLineMedTid("Hak grøntsager: slut");

            return "Kartofler og porrer";
        }

        public async Task LavPizzaAsync()
        {
            WriteLineMedTid("Pizza: start");
            await Task.Delay(3000);
            WriteLineMedTid("Pizza: slut");
        }

        public async Task LavBøfBearnaiseAsync()
        {
            WriteLineMedTid("BøfBearnaise: start");
            await Task.Delay(1000);
            WriteLineMedTid("BøfBearnaise: Rører lidt rundt");
            await Task.Delay(1000);
            WriteLineMedTid("BøfBearnaise: slut");
        }

        public async Task LavSuppeAsync(string hakkedeGrøntsager)
        {
            WriteLineMedTid("Suppe: start");
            await Task.Delay(2000);
            WriteLineMedTid($"Suppe: Vand koger, grøntsager hældes i: {hakkedeGrøntsager}");
            await Task.Delay(2000);
            WriteLineMedTid("Suppe: slut");
        }

        private void WriteLineMedTid(string tekst)
        {
            string tidsStempel = DateTime.Now.ToString("HH:mm:ss:fff");
            Console.WriteLine($"[{tidsStempel}] {tekst}");
        }
    }
}

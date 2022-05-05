using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetDårligeProgram.Funktionaliteter
{
    internal class SpilleMaskine
    {
        public void StartMøntSpil()
        {
            bool spillerSpil = true;
            while (spillerSpil)
            {
                SpilEtMøntSpil();
                spillerSpil = SpilIgen();
            }
        }

        public void StartLudoTerningSpil()
        {
            bool spillerSpil = true;
            while (spillerSpil)
            {
                SlåMedLudoTerning();
                spillerSpil = SpilIgen();
            }
        }

        public void StartStabelKlodserSpil()
        {
            bool spillerSpil = true;
            while (spillerSpil)
            {
                StabelLegoKlodser();
                spillerSpil = SpilIgen();
            }
        }

        private void SpilEtMøntSpil()
        {
            Console.WriteLine($"{Environment.NewLine}### FÅ PLAT MED EN MØNT ###");

            Random random = new Random();
            int randomTalMellemSomEr0Eller1 = random.Next(0, 2);

            // BUG! NULL REF
            Mønt enFattigMandsMønt = null;
            if (randomTalMellemSomEr0Eller1 == 0)
            {
                enFattigMandsMønt.ErJegPlat = true;
            }
            else
            {
                enFattigMandsMønt.ErJegPlat = false;
            }

            Console.WriteLine("### SLUT ###");
        }

        private void SlåMedLudoTerning()
        {
            Console.WriteLine($"{Environment.NewLine}### SLÅ MED EN LUDO TERNING ###");

            Random random = new Random();
            int randomTal = random.Next(0, 9);

            LudoTerningSider ludoTerningeSide = (LudoTerningSider)randomTal;

            Console.WriteLine("Det blev en " + ludoTerningeSide);
            Console.WriteLine("### SLUT ###");
        }

        private void StabelLegoKlodser()
        {
            Console.WriteLine($"{Environment.NewLine}### STABEL LEGO KLODSER ###");
            Console.WriteLine($"Indtast antal klodser:");

            // BUG! Hvis input er større end antal klodser! (System.ArgumentOutOfRangeException: Index was out of range.)
            // BUG! Hvis der ikke kommer noget input! (String.FormatException: Input string was not in a correct format)
            int højdePåHusIKlodser = int.Parse(Console.ReadLine());
            List<LegoKlods> legoKlodserTilRådighed = new List<LegoKlods>()
            {
                new LegoKlods() { Farve = "Grøn" },
                new LegoKlods() { Farve = "Grøn" },
                new LegoKlods() { Farve = "Grøn" },
                new LegoKlods() { Farve = "Rød" },
                new LegoKlods() { Farve = "Gul" },
                new LegoKlods() { Farve = "Gul" },
                new LegoKlods() { Farve = "Blå" },
            };

            List<LegoKlods> tårnAfLegoKlodser = new List<LegoKlods>();
            for (int index = 0; index < højdePåHusIKlodser; index++)
            {
                tårnAfLegoKlodser.Add(legoKlodserTilRådighed[index]);
            }

            Console.WriteLine($"Klodser i tårn:");
            for (int index = 0; index < tårnAfLegoKlodser.Count; index++)
            {
                Console.WriteLine($"Nr {index + 1}. {tårnAfLegoKlodser[index].Farve}");
            }

            Console.WriteLine("### SLUT ###");
        }

        private bool SpilIgen()
        {
            Console.WriteLine("Spil igen? (y/n)");
            string? brugerInput = Console.ReadLine();
            return brugerInput == "y";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlleMineVenner.TilrettelagtMateriale
{
    internal class PersonLogger
    {
        public void LogPersoner(IEnumerable<Person> personer, string logInfo)
        {
            ForberedNæsteLog(logInfo);

            var personerSomListe = personer.ToList();
            for (int index = 0; index < personerSomListe.Count; index++)
            {
                var person = personerSomListe[index];
                LogPerson(person, index);
            }
        }

        public void LogEnPerson(Person? person, string logInfo)
        {
            ForberedNæsteLog(logInfo);
            LogPerson(person);
        }

        public void LogListeAfTekster(IEnumerable<string?>? tekster, string logInfo)
        {
            var teksterSomListe = tekster?.ToList() ?? new List<string?>();
            ForberedNæsteLog(logInfo);
            for (int index = 0; index < teksterSomListe.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {teksterSomListe[index]}");
            }
        }

        private void ForberedNæsteLog(string logInfo)
        {
            Console.WriteLine();
            Console.WriteLine($"### {logInfo} ###");
        }

        private void LogPerson(Person? person, int index = 0)
        {
            if (person != null)
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.Append($"{index + 1}.");
                stringBuilder.Append($"\t Navn: {person.Fornavn} {person.Efternavn}");
                stringBuilder.Append($"\t Alder: {person.Alder}");
                stringBuilder.Append($"\t BrilleBruger: {person.BrugerBriller}");
                stringBuilder.Append($"\t Land: {person.Land}");

                string tøjSkrevetLæsevenligt = string.Join(", ", person.TøjEjet);
                stringBuilder.Append($"\t Tøj ejet: {tøjSkrevetLæsevenligt}");

                Console.WriteLine(stringBuilder.ToString());
            }
            else
            {
                Console.WriteLine("Ingen person!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlleMineVenner.TilrettelagtMateriale
{
    internal static class PersonFactory
    {
        private const string TShirt = "T-Shirt";
        private const string Bukser = "Bukser";

        public static List<Person> LavMigEnMassePersoner()
        {
            var personer = new List<Person>();

            personer.Add(LavEnPerson("Henning", "Jensen", brugerBriller: true));
            personer.Add(LavEnPerson("Flemming", "Jensen"));
            personer.Add(LavEnPerson("Lemming", "Jensen").TilegnTøj(TShirt, Bukser));
            personer.Add(LavEnPerson("Hansi", "Nielsen", brugerBriller: true));
            personer.Add(LavEnPerson("Grete", "Nielsen", alder: 18, land: Lande.Tyskland));
            personer.Add(LavEnPerson("Kaare", "Randersen").TilegnTøj(TShirt, TShirt, Bukser));
            personer.Add(LavEnPerson("Ida", "Randersen", alder: 60));
            personer.Add(LavEnPerson("Per", "Kirkegaard").TilegnTøj(TShirt, TShirt, Bukser));
            personer.Add(LavEnPerson("Jørn", "Kirkegaard", land: Lande.Frankrig).TilegnTøj(TShirt, Bukser, Bukser));
            personer.Add(LavEnPerson("Lisa", "Kirkegaard", land: Lande.Frankrig).TilegnTøj(TShirt, TShirt, Bukser));

            return personer;
        }

        private static Person LavEnPerson(
            string fornavn,
            string efternavn,
            int alder = 42,
            bool brugerBriller = false,
            Lande land = Lande.Danmark)
        {
            return new Person()
            {
                Fornavn = fornavn,
                Efternavn = efternavn,
                Alder = alder,
                BrugerBriller = brugerBriller,
                Land = land,
            };
        }

        private static Person TilegnTøj(this Person person, params string[] tøj)
        {
            foreach (var stykkeTøj in tøj)
            {
                person.TøjEjet.Add(stykkeTøj);
            }

            return person;
        }
    }
}

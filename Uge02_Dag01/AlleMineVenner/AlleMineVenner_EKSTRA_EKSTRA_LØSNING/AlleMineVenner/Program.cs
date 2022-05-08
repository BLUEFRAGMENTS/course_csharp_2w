using AlleMineVenner.TilrettelagtMateriale;

Console.WriteLine("Alle mine venner!");

List<Person> personer = PersonFactory.LavMigEnMassePersoner();
PersonLogger logger = new PersonLogger();

logger.LogPersoner(personer, "Her er alle mine venner!");

// Første
var første = personer.FirstOrDefault();
logger.LogEnPerson(første, "Første");

// Første Kirkegaard
var førsteKirkegaard = personer.FirstOrDefault(x => x.Efternavn == "Kirkegaard");
logger.LogEnPerson(førsteKirkegaard, "Første Kirkegaard");

// Briller
var alleMedBriller = personer.Where(x => x.BrugerBriller);
logger.LogPersoner(alleMedBriller, "Briller");

// Efternavne
var alleEfternavne = personer.Select(x => x.Efternavn);
logger.LogListeAfTekster(alleEfternavne, "Efternavne");

// Sorteret alfabetisk
var sorteretListe = personer.OrderBy(x => x.Fornavn);
logger.LogPersoner(sorteretListe, "Sorteret alfabetisk");

// Tøj
var tøj = personer.SelectMany(x => x.TøjEjet);
logger.LogListeAfTekster(tøj, "Alt tøj");

// EKSTRA
Console.WriteLine();
Console.WriteLine("EKSTRA");
var kirkegaardsTøj = personer
    .Where(x => x.Efternavn == "Kirkegaard")
    .SelectMany(x => x.TøjEjet);

logger.LogListeAfTekster(kirkegaardsTøj, "Kirkegaards tøj");

// EKSTRA EKSTRA Grupperet
Console.WriteLine();
Console.WriteLine("EKSTRA EKSTRA");
var grupperetILande = personer.GroupBy(x => x.Land);
foreach (var gruppe in grupperetILande)
{
    Console.WriteLine();
    Console.WriteLine($"### {gruppe.Key} ###");
    foreach (var person in gruppe)
    {
        Console.WriteLine($"{person.Fornavn} + {person.Efternavn}");
    }
}

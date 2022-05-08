using AlleMineVenner.TilrettelagtMateriale;

Console.WriteLine("Alle mine venner!");

List<Person> personer = PersonFactory.LavMigEnMassePersoner();
PersonLogger logger = new PersonLogger();

logger.LogPersoner(personer, "Her er alle mine venner!");
﻿using AlleMineVenner.TilrettelagtMateriale;

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

// See https://aka.ms/new-console-template for more information
using OnlinePizzaria;

Console.WriteLine("Online pizzaria!");

var pizzaApp = new PizzaApp();

// Programmet looper for evigt
while (true)
{
    // POST: Lav Pizza loop
    while (SkalOperationenStartes("BESTIL EN PIZZA"))
    {
        var ordre = await pizzaApp.LavEnOrdreAsync("Mathias Kirkegaard", "Pepperoni");
        if (ordre != null)
        {
            pizzaApp.SkrivPizzaOrdreUdIKonsollen(ordre);
        }
    }

    // GET: Hent alle Pizzaer loop
    while (SkalOperationenStartes("HENT ALLE BESTILLINGER"))
    {
        var listeAfPizzaOrdre = await pizzaApp.HentAlleOrdreAsync();
        pizzaApp.SkrivListeAfPizzaerIKonsollen(listeAfPizzaOrdre);
    }

    // EKSTRA: Slet en ordre loop
    while (SkalOperationenStartes("SLET ORDRE"))
    {
        Console.WriteLine("Skriv pizza id:");
        var input = Console.ReadLine();
        var erPizzaSlettet = await pizzaApp.SletEnOrdreAsync(input);
        Console.WriteLine(erPizzaSlettet ? "Pizza slettet!" : "Ingen pizza slettet");

        Console.WriteLine();
        Console.WriteLine("Check selv om pizzaen existere:");
        var listeAfPizzaOrdre = await pizzaApp.HentAlleOrdreAsync();
        pizzaApp.SkrivListeAfPizzaerIKonsollen(listeAfPizzaOrdre);
    }
}

bool SkalOperationenStartes(string operationTitle)
{
    Console.WriteLine();
    Console.WriteLine($"### Vil du kører operationen '{operationTitle}'? (y/n) ###");
    string? input = Console.ReadLine();

    Console.WriteLine();

    var skalGentages = input == "y";
    return skalGentages;
}

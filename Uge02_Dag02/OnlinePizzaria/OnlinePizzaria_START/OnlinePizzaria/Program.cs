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
        // SKRIV KODE HER:
        // Lav en pizza ordre fra pizzaApp her
    }

    // GET: Hent alle Pizzaer loop
    while (SkalOperationenStartes("HENT ALLE BESTILLINGER"))
    {
        // SKRIV KODE HER:
        // Hent alle pizza ordre fra pizza her
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

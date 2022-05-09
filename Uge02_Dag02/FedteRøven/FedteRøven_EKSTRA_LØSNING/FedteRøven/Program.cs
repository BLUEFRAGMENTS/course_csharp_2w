using FedteRøven;
using Newtonsoft.Json;

Console.WriteLine("### VELKOMMEN TIL FEDTERØVEN! ###");

var filHjælper = new FilHjælper();

// SKRIVE INITIAL DATA
Console.WriteLine("\nHenter eksisterende data...");
var eksisterendeTekst = await filHjælper.LæsFilHvisDenEksistereAsync();
Console.WriteLine("Eksisterende data:");
Console.WriteLine();
Console.WriteLine(eksisterendeTekst);
Console.WriteLine();

// SKRIV KODE HER
var alleUdlån = JsonConvert.DeserializeObject<List<UdLån>>(eksisterendeTekst);
if (alleUdlån == null)
{
    alleUdlån = new List<UdLån>();
}

foreach (var udlån in alleUdlån)
{
    Console.WriteLine(
        $"\nLån af {udlån.LånModtagersNavn}" +
        $" på {udlån.Kroner}kr.");

    var erUdlånForGammelt = (DateTime.UtcNow - udlån.Dato).TotalSeconds > 20;
    if (erUdlånForGammelt)
    {
        Console.WriteLine($"{udlån.LånModtagersNavn?.ToUpper()}! DU SKYLDER MIG PENGE!");
    }
}

while(SpørgIgen())
{
    // NAVN
    Console.WriteLine("\n\nHvad hedder du?");
    string? navn = string.Empty;
    do
    {
        navn = Console.ReadLine();
        if (string.IsNullOrEmpty(navn))
        {
            Console.WriteLine("A'hva? Ej prøv lige igen...");
        }
    }
    while (string.IsNullOrEmpty(navn));

    // LÅN
    Console.WriteLine("\nHvor meget skal du låne?");
    double lånIKr = 0;
    while (double.TryParse(Console.ReadLine(), out lånIKr) == false)
    {
        Console.WriteLine("A'hva? Ej prøv lige igen...");
    }

    // OPRET NYT LÅN
    Console.WriteLine($"\nOrk... {lånIKr}kr? ingen problem! Bare betal når du kommer til penge.");
    var udlån = new UdLån()
    {
        LånModtagersNavn = navn,
        Kroner = lånIKr,
        Dato = DateTime.UtcNow,
    };

    // SKRIV KODE HER
    alleUdlån.Add(udlån);

    var allUdlånSomJson = JsonConvert.SerializeObject(alleUdlån);
    await filHjælper.SkrivTilFilAsync(allUdlånSomJson);
}

Console.WriteLine("\n... nåååh... vi ses nok igen... hæ hæ hæ hæ...");
Console.ReadLine();

bool SpørgIgen()
{
    Console.WriteLine("\nEr der nogle der vil låne af mig? (hæhæhæ) (y/n)");
    var input = Console.ReadLine();
    var spørgIgen = input == "y";
    return spørgIgen;
}
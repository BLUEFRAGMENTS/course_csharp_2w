// See https://aka.ms/new-console-template for more information
using DenTravleKok;

Console.WriteLine("Velkommen til den travle kok!");

Kok denTravleKok = new Kok();

await denTravleKok.DrikKaffeAsync();
string grøntsager = await denTravleKok.HakGrøntsagerAsync();

Task opgave1 = denTravleKok.LavPizzaAsync();
Task opgave2 = denTravleKok.LavSuppeAsync(grøntsager);
await Task.WhenAll(opgave1, opgave2);

Console.WriteLine("Det var det for i dag! Farvel!");
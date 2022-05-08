// See https://aka.ms/new-console-template for more information
using DenTravleKok;

Console.WriteLine("Velkommen til den travle kok!");

Kok denTravleKok = new Kok();

await denTravleKok.DrikKaffeAsync();
string grøntsager = await denTravleKok.HakGrøntsagerAsync();

Task opgave1 = denTravleKok.LavPizzaAsync();
Task opgave2 = denTravleKok.LavSuppeAsync(grøntsager);
await Task.WhenAll(opgave1, opgave2);

// EKSTRA
Console.WriteLine("EKSTRA");

Task opgave3 = denTravleKok.LavPizzaAsync();
Task opgave4 = denTravleKok.LavSuppeAsync(grøntsager);
Task opgave5 = denTravleKok.LavBøfBearnaiseAsync();
await Task.WhenAll(opgave3, opgave4, opgave5);

// EKSTRA EKSTRA
Console.WriteLine("EKSTRA EKSTRA");

Task task1 = denTravleKok.LavPizzaAsync();
Task task2 = denTravleKok.LavSuppeAsync(grøntsager);
List<Task> tasks = new List<Task>() { task1, task2 };

while (tasks.Count > 0)
{
    Task task = await Task.WhenAny(tasks);
    if (task == task1)
    {
        Console.WriteLine("Pizza KLAR!");
    }
    else
    {
        Console.WriteLine("SUPPE KLAR!");
    }

    tasks.Remove(task);
}

Console.WriteLine("Det var det for i dag! Farvel!");

// Trin 1
List<string> biler = new List<string>();

// Trin 2
biler.Add("Mazda");
biler.Add("Toyota");
biler.Add("Hummer");

// Trin 3
biler.RemoveAt(1);

// Trin 4
biler.Add("Tesla");
biler.Add("BMW");

// Trin 5
for (int index = 0; index < biler.Count; index++)
{
    Console.WriteLine(biler[index]);
}
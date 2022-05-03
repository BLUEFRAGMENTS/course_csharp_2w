
// Trin 1
int[] personerIVogne = { 2, 3, 2, 5, 3, 2, 3, 5 };

// Trin 2
for (int index = 0; index < personerIVogne.Length; index++)
{
    int vognNummer = index + 1;
    Console.WriteLine("Vogn" + vognNummer + ": " + personerIVogne[index]);
}

// Trin 3
personerIVogne[1] += 2;
personerIVogne[5] += 2;

// Trin 4
Console.WriteLine("### Efter ændringer ###");
for (int index = 0; index < personerIVogne.Length; index++)
{
    int vognNummer = index + 1;
    Console.WriteLine("Vogn" + vognNummer + ": " + personerIVogne[index]);
}
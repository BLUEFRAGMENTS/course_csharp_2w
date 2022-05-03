int dag = 4;

// Omskriv denne
if (dag == 1)
{
    Console.WriteLine("Mandag");
}
else if (dag == 2)
{
    Console.WriteLine("Tirsdag");
}
else if (dag == 3)
{
    Console.WriteLine("Onsdag");
}
else if (dag == 4)
{
    Console.WriteLine("Torsdag");
}
else if (dag == 5)
{
    Console.WriteLine("Fredag");
}
else if (dag == 6)
{
    Console.WriteLine("Torsdag");
}
else if (dag == 7)
{
    Console.WriteLine("Fredag");
}
else
{
    Console.WriteLine("Den forlorne dag");
}

// STEP 1: Lav switch betingelse
switch (dag)
{
    // STEP 2: Lav cases
    case 1:
        Console.WriteLine("Mandag");
        break;

    case 2:
        Console.WriteLine("Tirsdag");
        break;

    case 3:
        Console.WriteLine("Onsdag");
        break;

    case 4:
        Console.WriteLine("Torsdag");
        break;

    case 5:
        Console.WriteLine("Fredag");
        break;

    case 6:
        Console.WriteLine("Lørdag");
        break;

    case 7:
        Console.WriteLine("Søndag");
        break;

    // STEP 3: Tilføj default
    default:
        Console.WriteLine("Den forlorne dag");
        break;
}

// EKSTRA
Ugedage ugedag = Ugedage.Onsdag;
switch (ugedag)
{
    case Ugedage.Mandag:
        Console.WriteLine("Mandag");
        break;

    case Ugedage.Tirsdag:
        Console.WriteLine("Tirsdag");
        break;

    case Ugedage.Onsdag:
        Console.WriteLine("Onsdag");
        break;

    case Ugedage.Torsdag:
        Console.WriteLine("Torsdag");
        break;

    case Ugedage.Fredag:
        Console.WriteLine("Fredag");
        break;

    case Ugedage.Lørdag:
        Console.WriteLine("Lørdag");
        break;

    case Ugedage.Søndag:
        Console.WriteLine("Søndag");
        break;
}

public enum Ugedage
{
    Mandag,
    Tirsdag,
    Onsdag,
    Torsdag,
    Fredag,
    Lørdag,
    Søndag,
}
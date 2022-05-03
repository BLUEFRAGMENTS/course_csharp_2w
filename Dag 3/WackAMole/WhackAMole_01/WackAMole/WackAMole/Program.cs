
// Trin 1
WackAMoleGame spil = new WackAMoleGame();

// Trin 2
spil.MoleDidShow += Spil_MoleDidShow;

void Spil_MoleDidShow(object? sender, EventArgs e)
{
    Console.WriteLine("Se en Mulvarpe!");
}

// Trin 3
spil.MoleDidHide += Spil_MoleDidHide;

void Spil_MoleDidHide(object? sender, EventArgs e)
{
    Console.WriteLine("Mulvarpen forsvandt!");
}

// Trin 4
spil.TriedToHitMole += Spil_TriedToHitMole;

void Spil_TriedToHitMole(object? sender, bool ramteJeg)
{
    if (ramteJeg)
    {
        Console.WriteLine("Ramt!");
    }
    else
    {
        Console.WriteLine("Misser!");
    }
}

// Trin 5
spil.StartGame();
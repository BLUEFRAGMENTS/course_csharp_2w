
// Trin 1
PoseMedDyr enPoseMedDyr = new PoseMedDyr();

// Trin 2
List<Dyr> alleDyr = enPoseMedDyr.HentAlleMineDyr();

// Trin 3
for (int index = 0; index < alleDyr.Count; index++)
{
    // Trin 4
    Dyr dyr = alleDyr[index];

    // Trin 5
    if (dyr is PatteDyr)
    {
        PatteDyr patteDyr = (PatteDyr)dyr;
        patteDyr.SkrivIKonsollen_HvadGørEtPatteDyr();
    }
    else if (dyr is KrybDyr)
    {
        KrybDyr krypDyr = (KrybDyr)dyr;
        krypDyr.SkrivIKonsollen_HvadHarEtKrypDyr();
    }
    else if (dyr is Fisk)
    {
        Fisk fisk = (Fisk)dyr;
        fisk.SkrivIKonsollen_HvadGørEnFisk();
    }
    else if (dyr is Insekt)
    {
        Insekt insekt = (Insekt)dyr;
        insekt.SkrivIKonsollen_HvadGørEtInsekt();
    }
}

// EKSTRA

Console.WriteLine();

Console.WriteLine("### PatteDyr ###");
for (int index = 0; index < alleDyr.Count; index++)
{
    Dyr dyr = alleDyr[index];
    if (dyr is PatteDyr)
    {
        PatteDyr patteDyr = (PatteDyr)dyr;
        patteDyr.SkrivIKonsollen_HvadGørEtPatteDyr();
    }
}

Console.WriteLine("### KrybDyr ###");
for (int index = 0; index < alleDyr.Count; index++)
{
    Dyr dyr = alleDyr[index];
    if (dyr is KrybDyr)
    {
        KrybDyr krypDyr = (KrybDyr)dyr;
        krypDyr.SkrivIKonsollen_HvadHarEtKrypDyr();
    }
}

Console.WriteLine("### Fisk ###");
for (int index = 0; index < alleDyr.Count; index++)
{
    Dyr dyr = alleDyr[index];
    if (dyr is Fisk)
    {
        Fisk fisk = (Fisk)dyr;
        fisk.SkrivIKonsollen_HvadGørEnFisk();
    }
}

Console.WriteLine("### Insekter ###");
for (int index = 0; index < alleDyr.Count; index++)
{
    Dyr dyr = alleDyr[index];
    if (dyr is Insekt)
    {
        Insekt insekt = (Insekt)dyr;
        insekt.SkrivIKonsollen_HvadGørEtInsekt();
    }
}
public class Insekt : Dyr
{
    public Insekt(string navn)
        : base(navn)
    {
    }

    public void SkrivIKonsollen_HvadGørEtInsekt()
    {
        Console.WriteLine(HentNavn() + ": Jeg er lille og god til at gemme mig.");
    }
}

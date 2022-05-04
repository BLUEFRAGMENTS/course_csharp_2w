public class Fisk : Dyr
{
    public Fisk(string navn)
        : base(navn)
    {
    }

    public void SkrivIKonsollen_HvadGørEnFisk()
    {
        Console.WriteLine(HentNavn() + ": Jeg svømmer en hel del.");
    }
}

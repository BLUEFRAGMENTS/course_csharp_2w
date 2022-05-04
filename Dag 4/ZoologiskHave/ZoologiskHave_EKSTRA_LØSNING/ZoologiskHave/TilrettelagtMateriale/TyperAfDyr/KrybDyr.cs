public class KrybDyr : Dyr
{
    public KrybDyr(string navn)
        : base(navn)
    {
    }

    public void SkrivIKonsollen_HvadHarEtKrypDyr()
    {
        Console.WriteLine(HentNavn() + ": Jeg har koldt blod.");
    }
}
public class PatteDyr : Dyr
{
    public PatteDyr(string navn)
        : base(navn)
    {
    }

    public void SkrivIKonsollen_HvadGørEtPatteDyr()
    {
        Console.WriteLine(HentNavn() +  ": Jeg føder levende unger.");
    }
}
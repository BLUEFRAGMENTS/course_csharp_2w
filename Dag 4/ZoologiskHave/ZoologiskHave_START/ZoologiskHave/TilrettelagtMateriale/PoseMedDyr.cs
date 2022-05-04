public class PoseMedDyr
{
    public List<Dyr> HentAlleMineDyr()
    {
        List<Dyr> alleMineDyr = new List<Dyr>()
        {
            new PatteDyr("Hest"),
            new PatteDyr("Hjort"),
            new PatteDyr("Ko"),
            new PatteDyr("Delfin"),
            new PatteDyr("Hund"),

            new Fisk("Torsk"),
            new Fisk("Ørred"),
            new Fisk("Klumpfisk"),
            new Fisk("Rødspætte"),

            new Insekt("Hveps"),
            new Insekt("Flue"),
            new Insekt("Edderkop"),
            new Insekt("Loppe"),

            new KrybDyr("Krokodille"),
            new KrybDyr("Firben"),
            new KrybDyr("Skildpadde"),
            new KrybDyr("Slange"),
        };

        var alleMineDyreIAlphabetiskRækkefølge = alleMineDyr
            .OrderBy(x => x.HentNavn())
            .ToList();

        return alleMineDyreIAlphabetiskRækkefølge;
    }
}


// #######################
// Få det her til at passe

// PERSONER
Person person1 = new Person("Rip", "Jensen");
Person person2 = new Person("Rap", "Jensen");
Person person3 = new Person("Rup", "Nielsen");
Person person4 = new Person("Ole", "Nielsen");

// HUSE
Hus hus1 = new Hus("Kursusvejen 2", person1, person2);
Hus hus2 = new Hus("Kodegade 5", person3, person4);

// By
List<Hus> huse = new List<Hus>() { hus1, hus2 };
By enBy = new By("By1", huse);
By enAndenBy = new By("By2", huse);

Land land = new Land("Danmark", new List<By>() { enBy, enAndenBy } );
land.FortælOmDigSelv(1);

// #######################

// Trin 1
public class Person
{
    private string _fornavn;
    private string _efternavn;

    public Person(
        string fornavn,
        string efternavn)
    {
        _fornavn = fornavn;
        _efternavn = efternavn;
    }

    public void FortælOmDigSelv(int indentation)
    {
        string spaces = new string(' ', indentation);
        Console.WriteLine(spaces + _fornavn + " " + _efternavn);
    }
}

// Trin 2
public class Hus
{
    private string _adresse;
    private Person _person1;
    private Person _person2;

    public Hus(string adresse, Person person1, Person person2)
    {
        _adresse = adresse;
        _person1 = person1;
        _person2 = person2;
    }

    public void FortælOmDigSelv(int indentation)
    {
        string spaces = new string(' ', indentation);
        Console.WriteLine(spaces + "Adresse: " + _adresse);

        indentation += 4;
        _person1.FortælOmDigSelv(indentation);
        _person2.FortælOmDigSelv(indentation);
    }
}

// Trin 3
public class By
{
    private string _byNavn;
    private List<Hus> _huse;

    public By(string byNavn, List<Hus> huse)
    {
        _byNavn = byNavn;
        _huse = huse;
    }

    public void FortælOmDigSelv(int indentation)
    {
        string spaces = new string(' ', indentation);
        Console.WriteLine(spaces + "Bynavn: " + _byNavn);

        indentation += 4;
        for (int index = 0; index < _huse.Count; index++)
        {
            _huse[index].FortælOmDigSelv(indentation);
        }
    }
}

public class Land
{
    private string _navn;
    private List<By> _byer;

    public Land(string navn, List<By> Byer)
    {
        _navn = navn;
        _byer = Byer;
    }

    public void FortælOmDigSelv(int indentation)
    {
        string spaces = new string(' ', indentation);
        Console.WriteLine(spaces + "Land: " + _navn);

        indentation += 4;
        for (int index = 0; index < _byer.Count; index++)
        {
            _byer[index].FortælOmDigSelv(indentation);
        }
    }
}
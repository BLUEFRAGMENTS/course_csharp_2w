
// #######################
// Få det her til at passe

// PERSONER
Person person1 = new Person("Rip", "Jensen");
Person person2 = new Person("Rap", "Jensen");

// HUS
Hus hus = new Hus("Kursusvejen 2", person1, person2);
hus.FortælOmDigSelv();

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

    public void FortælOmDigSelv()
    {
        Console.WriteLine(_fornavn + " " + _efternavn);
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

    public void FortælOmDigSelv()
    {
        Console.WriteLine("Adresse: " + _adresse);
        _person1.FortælOmDigSelv();
        _person2.FortælOmDigSelv();
    }
}
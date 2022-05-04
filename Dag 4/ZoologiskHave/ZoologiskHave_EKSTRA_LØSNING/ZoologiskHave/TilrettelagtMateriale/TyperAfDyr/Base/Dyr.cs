public class Dyr
{
    private string _navn;

    public Dyr(string navn)
    {
        _navn = navn;
    }

    public string HentNavn()
    {
        return _navn;
    }
}

using DoktorJournalen;

Console.WriteLine("Velkommen til Kursus Læge Praksis!");

var hånd = new Hånd();
var fod = new Fod();

hånd.TjekFingre();
hånd.TjekHåndflade();

fod.CheckHæl();
fod.CheckTæer();

// Duer ikke!
//DoktorJournal<string> doktorJournal = new DoktorJournal<string>();
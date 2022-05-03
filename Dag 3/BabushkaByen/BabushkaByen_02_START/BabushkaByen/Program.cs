
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

enBy.FortælOmDigSelv();

// #######################
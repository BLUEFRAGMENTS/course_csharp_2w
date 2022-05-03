// Trin 3
using Pizzaria;

Pizza magarita = new Pizza();
Pizza hawaii = new Pizza();
Pizza pepperoni = new Pizza();

// Trin 4
Console.WriteLine(
    "Magarita: "
    + magarita.TilføjTomatSovs()
    + " og "
    + magarita.TilføjOst());

Console.WriteLine(
    "Hawaii: "
    + hawaii.TilføjTomatSovs()
    + " og "
    + hawaii.TilføjOst()
    + " og "
    + hawaii.TilføjSkinke()
    + " og "
    + hawaii.TilføjAnananas());

Console.WriteLine(
    "Pepperoni: "
    + pepperoni.TilføjTomatSovs()
    + " og "
    + pepperoni.TilføjOst()
    + " og "
    + pepperoni.TilføjPepperoni());


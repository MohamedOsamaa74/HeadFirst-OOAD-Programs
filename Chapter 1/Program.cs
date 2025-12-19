using Chapter_1;
using Chapter_1.Enums;

Inventory inventory = new();
initializeInventory(inventory);
GuitarSpec whatErinLikes = new(Builder.Fender, "Startocastor", Chapter_1.Enums.Type.Electric, Wood.Alder, Wood.Alder, 12);

List<Guitar> guitars = inventory.Search(whatErinLikes);
if (guitars is not null)
{
    Console.WriteLine("Erin, you might like these\n");
    foreach (var guitar in guitars)
    {
        Console.WriteLine(guitar.GetSpec().GetNumString() + " " + guitar.GetSpec().GetBuilder() + " " + guitar.GetSpec().GetType()
            + " guitar:\n" + guitar.GetSpec().GetBackWood() + " back and sides,\n"
            + guitar.GetSpec().GetTopWood() + " top.\nYou can have this for only $" + guitar.GetPrice() + "!\n");
    }
}
else
{
    Console.WriteLine("Sorry, Erin, we have nothing for you.");


}

/*private static void initializeInventory(Inventory inventory)
{
    Guitar newGuitar = new("V95693", "Fender", "Startocastor", "electric", "Alder", "Alder", 1499.95);
}*/

static void initializeInventory(Inventory inventory)
{
    Guitar newGuitar = new("V95693", 1499.95,
        new GuitarSpec(Builder.Fender, "Startocastor", Chapter_1.Enums.Type.Electric, Wood.Alder, Wood.Alder, 12));
    inventory.AddGuitars(newGuitar);

    newGuitar = new("V9512", 1549.95,
        new GuitarSpec(Builder.Fender, "Startocastor", Chapter_1.Enums.Type.Electric, Wood.Alder, Wood.Alder, 12));
    inventory.AddGuitars(newGuitar);
    }

public class Ground
{
    public List<Item> items = new() { };
    //skapar en lista items

    public void ListItemsGround()
    {
        Console.WriteLine("På marken finns det ");
        foreach (Item i in items)
        {
            Console.Write(i.Name + ", ");
        }
    }
    //void för att skriva ut alla items

    public Ground()
    {
        List<string> Names = new() { "Axe", "Sword", "Bow", "Dagger", "Pickaxe", "Pouch", "Gold Ingot" };
        // Random generator = new Random();

        for (int i = 0; i < 16; i++)
        {
            Item item = new();
            int number = Random.Shared.Next(Names.Count);
            item.Name = Names[number];
            item.Space = Random.Shared.Next(1, 20);
            items.Add(item);
        }

    }
    //skapar alla items i ground
}
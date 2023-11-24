public class Ground
{
    Item item = new();
    public List<Item> items = new() { };

    public void ListItems()
    {
        foreach (Item i in items)
        {
            Console.WriteLine(i.Name);
        }
    }

    public Ground()
    {
        List<string> Names = new() { "Axe", "Sword", "Bow", "Dagger", "Pickaxe", "Pouch", "Gold Ingot" };
        // Random generator = new Random();

        for (int i = 0; i < 16; i++)
        {
            int number = Random.Shared.Next(Names.Count);
            item.Name = Names[number];
            item.Space = Random.Shared.Next(1, 20);
            items.Add(item);
        }

    }

}
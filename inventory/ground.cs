using System.Runtime.CompilerServices;

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
        List<string> NamesItem = new() { "Pouch", "Gold Ingot", "Arrows", "Copper Ingot", "Iron Ingot" };
        List<string> NamesWeapon = new() { "Axe", "Sword", "Bow", "Dagger", "Pickaxe" };


        for (int i = 0; i < 6; i++)
        {
            Item item = new();
            int number = Random.Shared.Next(NamesItem.Count);
            item.Name = NamesItem[number];
            item.Space = Random.Shared.Next(1, 20);
            items.Add(item);
        }
        for (int i = 0; i < 6; i++)
        {
            weapon weapon = new();
            int number = Random.Shared.Next(NamesWeapon.Count);
            weapon.Name = NamesWeapon[number];
            if (i % 2 == 0)
            {
                weapon.Name = weapon.IsLong + NamesWeapon[number];
            }
            else
            {
                weapon.Name = weapon.IsShort + NamesWeapon[number];
            }

            weapon.Space = Random.Shared.Next(1, 20);
            items.Add(weapon);


        }
        //skapar alla items i ground
    }
}
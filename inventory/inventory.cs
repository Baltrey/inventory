using System.Dynamic;

public class inventory
{
    public readonly int InventorySpace = 20;

    //gör så man inte kan ändra på värdet på space
    public List<Item> items = new();
    public void ListItemsInventory()
    {
        Console.WriteLine("Du har: ");
        foreach (Item i in items)
        {
            Console.Write(i.Name + ", ");
        }
    }
}
//skapar classen inventory med en lista som kan innehålla items
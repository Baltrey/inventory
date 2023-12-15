using System.Dynamic;

public class inventory
{
    int _inventorySpace = 20;
    public int InventorySpace
    {
        get
        {
            if (_inventorySpace > 0)
            {
                return _inventorySpace;
            }
            else
            {
                _inventorySpace = 0;
                return _inventorySpace;
            }

        }
        set
        {
            if (value > 0 && value < 21)
            {
                _inventorySpace = InventorySpace;
            }
        }
    }

    //gör så man inte kan ändra på värdet på space
    public Stack<Item> items = new();
    public void ListItemsInventory()
    {
        Console.WriteLine("Du har: ");
        foreach (Item i in items)
        {
            Console.Write(i.Name + ", ");
        }
        Console.Write("Och har " + InventorySpace + " plats kvar");
    }
}
//skapar classen inventory med en lista som kan innehålla items
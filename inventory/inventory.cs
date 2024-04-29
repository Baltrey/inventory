using System.Dynamic;

public class Inventory
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
                _inventorySpace = value;
            }
            else
            {
                _inventorySpace = 0;
            }
        }
    }

    //gör så man inte kan ändra på värdet på space
    public Stack<Item> Items = new();
    public void ListItemsInventory()
    {
        Console.Clear();
        Console.WriteLine("Du har: ");
        foreach (Item i in Items)
        {
            if (i is WeightedItem)
            {
                Console.Write(((WeightedItem)i).Weight);
            }
            if (i is Weapon)
            {
                Console.Write(((Weapon)i).Length);
                Console.Write(((Weapon)i).Weight);
            }
            Console.Write(i.Name + ", ");

        }
        Console.WriteLine("och plats kvar i inventory " + InventorySpace);
        //void för att skriva ut alla items i inventory som skriver även ut weight och Length om de har det
    }
    public void Reset()
    {
        _inventorySpace = 20;
        Items.Clear();
    }
    //startar om inventory, tar bort allt i det och tar upp space till max
}
//skapar classen inventory med en lista som kan innehålla items

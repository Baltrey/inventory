using System.Dynamic;

public class inventory
{
    int _inventorySpace = 20;
    public int InventorySpace
    {
        get
        {
            InventorySpace = _inventorySpace;
            return InventorySpace;
        }
        set
        {

        }
    }
    public List<Item> content = new();
}
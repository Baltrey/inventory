
public class ShopFunction : Function
{
    public void buy(Inventory inventory, List<ShopItem> shopItems, int index)
    {

        if (inventory.coins >= ((shopItems[index]).Cost))
        {
            inventory.coins -= ((shopItems[index]).Cost);
            inventory.Items.Push(shopItems[index]);
            shopItems.RemoveAt(index);
            inventory.ListItemsInventory(inventory);
        }
        else
        {
            Console.WriteLine("för lite pengar:(");
        }
    }
    public void sell(Inventory inventory)
    {
        if (Value((inventory.Items.Peek().Name), (inventory.Items.Peek().Value)))
        {
            inventory.coins += (inventory.Items.Peek().Value);
            inventory.InventorySpace += (inventory.Items.Peek().Space);
            inventory.Items.Pop();
        }
        else
        {

        }
    }
    public bool Value(string name, int value)
    {
        Console.Clear();
        Console.WriteLine("Jag Kan ge dig " + value + " för ditt senaste item " + name);
        Console.WriteLine("Vill du sälja det Y/N");
        if (YesAndNo())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

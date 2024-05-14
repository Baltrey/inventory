
public class ShopFunction
{
    public void buy(Inventory inventory, List<ShopItem> shopItems, int index)
    {

        if (inventory.coins >= ((shopItems[index]).Cost))
        {
            inventory.coins -= ((shopItems[index]).Cost);
            inventory.Items.Push(shopItems[index]);
            shopItems.RemoveAt(index);
            inventory.ListItemsInventory();
        }
        else
        {
            Console.WriteLine("för lite pengar:(");
        }
    }
    public void sell()
    {

    }
}

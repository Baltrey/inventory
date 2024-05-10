using System.Reflection.Metadata.Ecma335;

Ground ground = new();
Inventory inventory = new();
Shop shop = new();
Function function = new();
//skapar ground och inventory från klasserna ground och inventory i main programet, samt functions för kommandon

bool Game = true;
//variabeln för spelet

while (true)
{
    ground.Groundstart();
    Game = true;
    ground.ListItemsGround();
    //metoder för att starta samt visa items i början

    while (Game)
    {
        int i = (ground.Answer(ground.items.Count) - 1);
        if (inventory.InventorySpace > 0)
        {
            inventory.InventorySpace = inventory.InventorySpace - ground.items[i].Space;
            inventory.Items.Push(ground.items[i]);
            ground.items.RemoveAt(i);
            inventory.ListItemsInventory();
            ground.ListItemsGround();
        }
        //kollar om inventory space är mer än 0, om det är det kör spelet vidare. Annars stängs det av.
        else
        {
            Game = false;
        }
        if (shop.AskOpenShop())
        {
            if (shop.BuySell())
            {
                shop.ListItems();
                int index = ground.Answer(shop.shopItems.Count);

            }
            else
            {
                if (shop.Value((inventory.Items.Peek().Name), (inventory.Items.Peek().Value)))
                {
                    inventory.coins += (inventory.Items.Peek().Value);
                    inventory.Items.Pop();
                }
                else
                {

                }
            }
        }
        //frågar om du vill öppna shopen
    }
    Console.Clear();
    Console.WriteLine("Du fick slut på plats i ditt inventory");
    Console.WriteLine("");
    Console.WriteLine("vill du köra igen Y/N");
    if (function.YesAndNo())
    {
        inventory.Reset();
        ground.Groundstart();
    }
    else
    {
        return;
    }
    //kollar funktion playagain och avslutar spelet om false, annars börjas ett nytt spel
}
//main loopen för spelet
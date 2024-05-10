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

    //metoder för att starta

    while (Game)
    {
        ground.ListItemsGround();
        int i = (ground.Answer(ground.items.Count) - 1);
        if (inventory.InventorySpace > 0)
        {
            inventory.InventorySpace = inventory.InventorySpace - ground.items[i].Space;
            inventory.Items.Push(ground.items[i]);
            ground.items.RemoveAt(i);
            inventory.ListItemsInventory();
            if (shop.AskOpenShop())
            {
                if (shop.BuySell())
                {
                    Console.WriteLine("Du har " + inventory.coins + " coins");
                    shop.ListItems();
                    int index = (ground.Answer(shop.shopItems.Count) - 1);


                    if (inventory.coins >= ((shop.shopItems[index]).Cost))
                    {
                        inventory.coins -= ((shop.shopItems[index]).Cost);
                        inventory.Items.Push(shop.shopItems[i]);
                        shop.shopItems.RemoveAt(index);
                        inventory.ListItemsInventory();
                    }
                    else
                    {
                        Console.WriteLine("för lite pengar:(");
                    }

                }
                else
                {
                    if (shop.Value((inventory.Items.Peek().Name), (inventory.Items.Peek().Value)))
                    {
                        inventory.coins += (inventory.Items.Peek().Value);
                        inventory.InventorySpace += (inventory.Items.Peek().Space);
                        inventory.Items.Pop();
                    }
                    else
                    {

                    }
                }
            }
            //frågar om du vill öppna shopen
        }
        //kollar om inventory space är mer än 0, om det är det kör spelet vidare. Annars stängs det av.
        else
        {
            Game = false;
        }

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
using System.Reflection.Metadata.Ecma335;

Ground ground = new();
Inventory inventory = new();
Shop shop = new();
Function function = new();
//skapar ground och inventory från klasserna ground och inventory i main programet, samt functions för kommandon

bool Game = false;
//variabeln för spelet

while (true)
{

    //metoder för att starta
    Game = function.StartGame(inventory, ground, Game);
    while (Game)
    {
        ground.ListItemsGround(ground);
        int i = (ground.Answer(ground.items.Count) - 1);
        if (inventory.InventorySpace > 0)
        {
            inventory.ListItemsInventory(inventory);
            shop.OpenShop(inventory, ground, shop.ShopItems);


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
    }
    else
    {
        return;
    }
    //kollar funktion playagain och avslutar spelet om false, annars börjas ett nytt spel
}
//main loopen för spelet
using System.Reflection.Metadata.Ecma335;

Ground ground = new();
inventory inventory = new();
funtion funtion = new();
//skapar ground och inventory från klasserna ground och inventory i main programet, samt functions för kommandon
bool Game = true;
//variabeln för spelet

while (true)
{
    Game = true;
    ground.ListItemsGround();
    while (Game)
    {
        int i = (funtion.answer() - 1);
        if (inventory.InventorySpace > 0)
        {
            inventory.InventorySpace = inventory.InventorySpace - ground.items[i].Space;
            inventory.items.Push(ground.items[i]);
            ground.items.RemoveAt(i);
            inventory.ListItemsInventory();
            ground.ListItemsGround();
        }
        //kollar om inventory space är mer än 0, om det är det kör spelet vidare. Annars stängs det av.
        else
        {
            Game = false;
        }
    }

    if (funtion.playagain())
    {
        inventory.InventorySpace = 20;
    }
    else
    {
        return;
    }
    //kollar funktion playagain och avslutar spelet om false, annars börjas ett nytt spel
}
//main loopen för spelet
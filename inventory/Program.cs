using System.Reflection.Metadata.Ecma335;

Ground ground = new();
Inventory inventory = new();
Function function = new();
//skapar ground och inventory från klasserna ground och inventory i main programet, samt functions för kommandon
bool Game = true;
//variabeln för spelet

while (true)
{
    ground.Groundstart();
    Game = true;
    ground.ListItemsGround();
    while (Game)
    {
        int i = (function.Answer(ground.items.Count) - 1);
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
    }

    if (function.PlayAgain())
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
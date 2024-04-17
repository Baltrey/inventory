Ground ground = new();
inventory inventory = new();

//skapar ground och inventory från klasserna ground och inventory i main programet
bool Game = true;
//variabeln för spelet

while (true)
{
    Game = true;
    ground.ListItemsGround();
    while (Game)
    {
        int i = (answer() - 1);
        if (inventory.InventorySpace > 0)
        {
            inventory.InventorySpace = inventory.InventorySpace - ground.items[i].Space;
            inventory.items.Push(ground.items[i]);
            ground.items.RemoveAt(i);
            inventory.ListItemsInventory();

        }
        //kollar om inventory space är mer än 0, om det är det kör spelet vidare. Annars stängs det av.
        else
        {
            Game = false;
        }
        ground.ListItemsGround();
    }
}
//main loopen för spelet
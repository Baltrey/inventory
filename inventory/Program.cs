﻿//items
//name,space, 
Ground ground = new();
inventory inventory = new();
bool Game = true;

while (true)
{
    Game = true;
    ground.ListItemsGround();
    while (Game)
    {
        int i = (answer() - 1);
        if (inventory.InventorySpace > 0)
        {
            inventory.InventorySpace -= ground.items[i].Space;
            inventory.items.Push(ground.items[i]);
            ground.items.RemoveAt(i);
            inventory.ListItemsInventory();
        }
        else
        {
            Game = false;
        }
        ground.ListItemsGround();
    }
}
//main loopen för spelet



int answer()
{
    Console.WriteLine("");
    Console.WriteLine("Skriv ett nummer mellan 1-15");
    while (true)
    {
        int j = GetNummber();
        if (j > 0 && j < 16)
        {

            return j;
        }

        else
        {
            Console.WriteLine("SKRIV ETT NUMMER MELLAN 1-15!!!!");

            for (int s = 0; s < 10; s++)
            {
                Console.Beep(2000, 100);
            }
        }
    }
}
//får ett answer och retunerar en int
int GetNummber()
{
    string i = "";

    int j;
    while (!int.TryParse(i, out j) == true)
    {
        i = Console.ReadLine();
        if ((!int.TryParse(i, out j) == true))
        {
            Console.WriteLine("SKRIV ETT NUMMER!!!!");

            for (int s = 0; s < 10; s++)
            {
                Console.Beep(2000, 100);
            }
        }
    }
    return j;
}
//kollar så att det är ett nummer och inte text
//items
//name,space, 
Ground ground = new();
inventory inventory = new();
bool Game = true;

while (true)
{
    ground.ListItemsGround();
    while (Game)
    {
        int i = answer();
        if ((inventory.InventorySpace - ground.items[i].Space) >= 0)
        {
            inventory.items.Add(ground.items[i]);
            ground.items.RemoveAt(i);
            inventory.ListItemsInventory();
        }
    }
}
//main loopen för spelet


int answer()
{
    Console.WriteLine("");
    Console.WriteLine("Skriv ett nummer mellan 0-15");
    while (true)
    {
        int j = GetNummber();
        if (j >= 0 && j < 16)
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
    }
    return j;
}
//kollar så att det är ett nummer och inte text
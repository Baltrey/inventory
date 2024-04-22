using System.Runtime.CompilerServices;

public class Ground
{
    public List<Item> items = new() { };
    //skapar en lista items

    public void ListItemsGround()
    {
        Console.WriteLine("");
        Console.WriteLine("På marken finns det ");
        foreach (Item i in items)
        {
            if (i is WeightedItems)
            {
                Console.Write(((WeightedItems)i).Weight);
            }
            if (i is Weapon)
            {
                Console.Write(((Weapon)i).Length);
            }
            Console.Write(i.Name + "(" + i.Space + ")" + ", ");

        }
    }
    //void för att skriva ut alla items i ground som skriver även ut weight och Length om de har det

    public void Groundstart()
    {
        items.Clear();
        string[] NamesItem = { "Pouch", "Arrows", "Copper Ingot", "Iron Ingot", "Gold Ingot" };
        string[] NamesWeapon = { "Axe", "Sword", "Bow", "Dagger", "Pickaxe" };


        for (int i = 0; i < 6; i++)
        {
            Item item = new();
            int number = Random.Shared.Next(NamesItem.Length);
            if (number > 1)
            {
                WeightedItems weightedItems = new();
                if (i % 2 == 0)
                {
                    weightedItems.Weight = "Light ";
                }
                else
                {
                    weightedItems.Weight = "Heavy ";
                }
                weightedItems.Name = NamesItem[number];
                weightedItems.Space = Random.Shared.Next(1, 20);
                items.Add(weightedItems);
            }
            else
            {
                item.Name = NamesItem[number];
                item.Space = Random.Shared.Next(1, 20);
                items.Add(item);
            }
            //sätter ut heavy på alla items som kan vara heavy
        }
        //skapar alla items med weight och de som inte ska ha weight i ground
        for (int i = 0; i < 6; i++)
        {
            Weapon weapon = new();
            int number = Random.Shared.Next(NamesWeapon.Length);
            weapon.Name = NamesWeapon[number];
            weapon.Space = Random.Shared.Next(1, 20);
            //skapar ett vapen från klassen och sätter ut namn och space med hjälp av random generator och tidigare array
            if (weapon.Space >= 18)
            {
                weapon.Name = "Shiny " + weapon.Name;
                // Shiny shinyWeapon = new();
                // shinyWeapon.Name = weapon.Name;
                // shinyWeapon.Space = weapon.Space;
                // shinyWeapon.shiny = true;
            }

            weapon.Weight = i % 2 == 0 ? "Light" : "Heavy";

            if (i % 2 == 0)
            {
                weapon.Weight = "Light ";
                weapon.Length = "Short ";
            }
            else
            {
                weapon.Weight = "Heavy ";
                weapon.Length = "Long ";
            }
            items.Add(weapon);
            //sätter heavy och long på varanan vapen, dervärsa med ligth

        }
        //skapar weapon items i ground
    }
}
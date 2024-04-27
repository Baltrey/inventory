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

        for (int i = 0; i < 6; i++)
        {
            WeightedItems item = new();
            int number = Random.Shared.Next(item.NamesWeightedItems.Length);
            item.Name = item.getNames(number);
            item.Weight = item.GetWeight(i);
            //borde ändra
            items.Add(item);
            //sätter ut heavy på alla items som kan vara heavy
        }
        //skapar alla items med weight och de som inte ska ha weight i ground
        for (int i = 0; i < 6; i++)
        {
            Weapon weapon = new();
            int number = Random.Shared.Next(weapon.NamesWeapon.Length);
            weapon.Name = weapon.getNames(number);
            //hämtar namn
            weapon.Length = weapon.Getlength(i);
            weapon.Weight = weapon.GetWeight(i);
            //sätter heavy och long på varanan vapen, dervärsa med ligth
            //skapar ett vapen från klassen och sätter ut namn och space med hjälp av random generator och tidigare array
            if (weapon.Space >= 18)
            {
                weapon.Name = "Shiny " + weapon.Name;
                // Shiny shinyWeapon = new();
                // shinyWeapon.Name = weapon.Name;
                // shinyWeapon.Space = weapon.Space;
                // shinyWeapon.shiny = true;
            }
            //borde ändra senare
            items.Add(weapon);
        }
        //skapar weapon items i ground
    }
}
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
            if (i is WeightedItem)
            {
                Console.Write(((WeightedItem)i).Weight);
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
            WeightedItem item = new();
            items.Add(item);
            //sätter ut heavy på alla items som kan vara heavy
        }
        //skapar items och sätter de i listan items
        for (int i = 0; i < 6; i++)
        {
            Weapon weapon = new();
            items.Add(weapon);
        }
        //skapar weapon items i listan items
    }
}
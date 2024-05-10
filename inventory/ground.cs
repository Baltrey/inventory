using System.Runtime.CompilerServices;

public class Ground
{
    Function function = new();
    public List<Item> items = new() { };
    //skapar en lista items

    public void ListItemsGround()
    {
        Console.WriteLine("");
        Console.WriteLine("På marken finns det ");
        Console.WriteLine("");
        foreach (Item i in items)
        {
            if (i is WeightedItem)
            {
                Console.Write(((WeightedItem)i).Weight);
            }
            if (i is Weapon)
            {
                if (((Weapon)i).IsShiny)
                {
                    Console.Write("Shiny ");
                }
                Console.Write(((Weapon)i).Length);
            }
            Console.Write(i.Name + "(" + i.Space + ")" + ", ");

        }
        Console.WriteLine("");
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
    public int Answer(int groundAmount)
    {
        Console.WriteLine("");
        Console.WriteLine("Skriv ett nummer mellan 1-" + groundAmount);
        while (true)
        {
            int j = function.GetNummber();
            if (j > 0 && j <= groundAmount)
            {

                return j;
            }
            //kollar att numret är inom det angivna intervalet

            else
            {
                Console.WriteLine("SKRIV ETT NUMMER MELLAN 1-" + groundAmount + "!!!!");
            }
            //ger instruktioner ifall fel input
        }
    }
    //får ett answer och retunerar en int

}
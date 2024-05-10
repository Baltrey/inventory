using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Shop
{
    Function function = new();
    public List<ShopItem> shopItems = new();
    public class ShopItem : Item
    {
        int _cost = (_space * 10);
        public int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
        bool _soldOut = false;
        public bool SoldOut
        {
            get
            {
                return _soldOut;
            }
            set
            {
                _soldOut = value;
            }
        }
    }
    public Shop()
    {
        string[] TypePotion = { "Health", "Speed", "Poison", "Strength", "Weakness", "Slowness", "Jump" };
        for (int i = 0; i < 10; i++)
        {
            ShopItem shopItem = new();
            int index = Random.Shared.Next(1, (TypePotion.Length));
            shopItem.Name = (TypePotion[index] + " Potion");
            shopItems.Add(shopItem);
        }
    }
    public bool AskOpenShop()
    {
        Console.WriteLine();
        Console.WriteLine("Vill du öppna shopen? Y/N");
        string? i = Console.ReadLine();
        if (i.ToUpper() == "Y")
        {
            Console.Clear();
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool BuySell()
    {
        Console.WriteLine("Vill du köpa eller sälja? 1 för att köpa 2 för att sälja");
        int i = Answer(2);
        if (i == 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public void ListItems()
    {
        Console.WriteLine("I shopen finns: ");
        foreach (var item in shopItems)
        {
            if (item.SoldOut)
            {
                Console.Write("SOLD OUT!");
            }
            else
            {
                Console.Write(item.Name + "(" + "Kostar " + item.Cost + ")" + ", ");
            }
        }
        Console.WriteLine("skriv ett nummer till följande item i följd");
    }
    public bool Value(string name, int value)
    {
        Console.Clear();
        Console.WriteLine("Jag Kan ge dig " + value + "för ditt senaste item" + name);
        Console.WriteLine("Vill du sälja det Y/N");
        if (function.YesAndNo())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    int Answer(int Amount)
    {
        while (true)
        {
            int j = function.GetNummber();
            if (j > 0 && j <= Amount)
            {

                return j;
            }
            //kollar att numret är inom det angivna intervalet

            else
            {
                Console.WriteLine("SKRIV ETT NUMMER, 1 eller" + Amount + "!!!!");
            }
            //ger instruktioner ifall fel input
        }
    }
    //får ett answer och retunerar en int
}
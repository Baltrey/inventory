using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Shop
{
    Function function = new();
    public List<ShopItem> ShopItems { get; set; } = new();
    ShopFunction shopFunction = new();
    public Shop()
    {

        string[] TypePotion = { "Health", "Speed", "Poison", "Strength", "Weakness", "Slowness", "Jump" };
        for (int i = 0; i < 10; i++)
        {
            ShopItem shopItem = new();
            int index = Random.Shared.Next(1, (TypePotion.Length));
            shopItem.Name = (TypePotion[index] + " Potion");
            ShopItems.Add(shopItem);
        }
    }
    public void OpenShop(Inventory inventory, Ground ground, List<ShopItem> shopItems)
    {
        if (AskOpenShop())
        {
            if (BuySell())
            {
                Console.WriteLine("Du har " + inventory.coins + " coins");
                ListItems(shopItems);
                int index = (ground.Answer(shopItems.Count) - 1);
                shopFunction.buy(inventory, shopItems, index);
            }
            else
            {
                shopFunction.sell(inventory);
            }

        }
        //frågar om du vill öppna shopen
    }
    bool AskOpenShop()
    {
        Console.WriteLine("");
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
    bool BuySell()
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
    public bool Value(string name, int value)
    {
        Console.Clear();
        Console.WriteLine("Jag Kan ge dig " + value + " för ditt senaste item " + name);
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
    public void ListItems(List<ShopItem> shopItems)
    {
        Console.WriteLine("");
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

}
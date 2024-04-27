using System.Dynamic;

public class Item
{
    public string? Name;
    //items namn

    int _space = Random.Shared.Next(1, 20);
    public int Space
    {
        get
        {
            return _space;
        }
        set
        {
            if (value >= 0 && value < 20)
            {
                _space = value;

            }
        }
    }
    //sätter gränserna att ett items space value bara kan vara mellan 0 och 20

}
//skapar klassen items
public class WeightedItems : Item
{
    public string? Weight;
    string[] _NamesWeightedItems = { "Pouch", "Arrows", "Copper Ingot", "Iron Ingot", "Gold Ingot" };
    public string[] NamesWeightedItems
    {
        get
        {
            return _NamesWeightedItems;
        }
    }

    public virtual string getNames(int item)
    {
        string i = _NamesWeightedItems[item];

        return i;
    }
    //metod för att få ut namn på item
    public string GetWeight(int times)
    {
        string i;
        if (times % 2 == 0)
        {
            i = "Light ";
        }
        else
        {
            i = "Heavy ";
        }
        return i;

    }
    //metod för att få ut Weight på items
}
//skapar subclass weighted items av item
public class Weapon : WeightedItems
{
    public string? Length;
    string[] _NamesWeapon = { "Axe", "Sword", "Bow", "Dagger", "Pickaxe" };
    public string[] NamesWeapon
    {
        get
        {
            return _NamesWeapon;
        }
    }
    public override string getNames(int item)
    {
        string i = _NamesWeapon[item];

        return i;
    }
    //ändrar metoden getNames så den följer listan namesWeapon istället
    public string Getlength(int times)
    {
        string i;
        if (times % 2 == 0)
        {
            i = "Short";
        }
        else
        {
            i = "Long";
        }
        return i;
    }
    //metod för att få längd på Weapon

}
//subclass weapon av weightedItems
public class Shiny : Weapon
{
    public bool shiny;


}
//Skapar en subclass Weapon av Weighteditems
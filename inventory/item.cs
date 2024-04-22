using System.Dynamic;

public class Item
{
    public string? Name;
    //items namn

    int _space;
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
}
//skapar subclass weighted items av item
public class Weapon : WeightedItems
{
    public string? Length;

}
public class Shiny : Weapon
{
    public bool shiny;

}
//Skapar en subclass Weapon av Weighteditems
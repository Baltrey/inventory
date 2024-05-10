using System.Dynamic;
using System.Runtime.CompilerServices;

public class Item
{
    public string? Name { get; set; }
    //items namn
    int _value = Random.Shared.Next(10, 200);
    public int Value { get { return _value; } set { } }
    static protected int _space = Random.Shared.Next(1, 20);
    public int Space
    {
        get { return _space; }
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
public class WeightedItem : Item
{
    public string? Weight { get; set; }
    string[] _namesWeightedItems = { "Pouch", "Arrows", "Copper Ingot", "Iron Ingot", "Gold Ingot" };

    private static bool _lastWasHeavy = false;
    //bool för att kolla om senaste item var heavy

    public WeightedItem()
    {
        int _number = Random.Shared.Next(_namesWeightedItems.Length);
        Name = GetNames(_number);
        Weight = GetWeight();
        _lastWasHeavy = !_lastWasHeavy;
    }
    //konstruktor

    public virtual string GetNames(int item)
    {
        string i = _namesWeightedItems[item];

        return i;
    }
    //metod för att få ut namn på item
    public string GetWeight()
    {
        string i;
        if (_lastWasHeavy)
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
public class Weapon : WeightedItem
{
    public string? Length { get; set; }
    string[] _namesWeapon = { "Axe", "Sword", "Bow", "Dagger", "Pickaxe" };
    private static bool _lastWasLong = false;
    bool _isShiny = false;
    public bool IsShiny
    {
        get
        {
            return _isShiny;
        }
        set
        {
            _isShiny = value;
        }
    }
    public Weapon()
    {
        int number = Random.Shared.Next(_namesWeapon.Length);
        Name = GetNames(number);
        Length = Getlength();
        if (Space >= 18)
        {
            IsShiny = true;
        }
        _lastWasLong = !_lastWasLong;
    }
    public override string GetNames(int item)
    {
        string i = _namesWeapon[item];

        return i;
    }
    //ändrar metoden getNames så den följer listan namesWeapon istället
    public string Getlength()
    {
        string i;
        if (_lastWasLong)
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
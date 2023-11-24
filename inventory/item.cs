using System.Dynamic;

public class Item
{
    public string Name;

    int _space;
    public int Space
    {
        get
        {
            Space = _space;
            return Space;
        }
        set
        {
            if (value > 0 && value < 20)
            {
                Space = value;
            }
        }
    }

}
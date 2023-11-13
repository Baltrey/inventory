using System.Dynamic;

public class Item
{
    public string Name;
    int _space = 1;
    public int Space
    {
        get
        {
            return _space;
        }
        set
        {
            if (value > 0 && value < 20)
            {
                _space = value;
            }
        }
    }

}
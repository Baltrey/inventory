using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
public class Function
{
    public int GetNummber()
    {
        string? i = "";

        int j;
        while (!int.TryParse(i, out j) == true)
        {
            i = Console.ReadLine();
            if ((!int.TryParse(i, out j) == true))
            {
                Console.WriteLine("SKRIV ETT NUMMER!!!!");

            }
            //kollar att det är ett nummer, om inte ger användaren instruktioner att det är fel
        }
        //kör loopen tills användaren har skrivit ett nummer, sammt gör en try parse med answer och kollar att det går
        return j;
        //retunerar numret som j
    }
    //kollar så att det är ett nummer och inte text

    public void Beep()
    {
        for (int s = 0; s < 10; s++)
        {
            Console.Beep(2000, 500);
            Thread.Sleep(200);
        }
        //kör loopen 10 gånger
    }
    //lägger till en beep funtion

    public bool YesAndNo()
    {
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
    //funktion för att spelaren ska kunna köra igen, kollar input Y/N
    public bool StartGame(Inventory inventory, Ground ground, bool Game)
    {
        Reset(inventory, ground);
        Game = true;
        return Game;
    }
    public void Reset(Inventory inventory, Ground ground)
    {
        inventory.Reset(inventory);
        ground.Groundstart(ground);
    }
}

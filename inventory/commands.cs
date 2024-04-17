using System.Dynamic;
public class commands
{
    public int GetNummber()
    {
        string i = "";

        int j;
        while (!int.TryParse(i, out j) == true)
        {
            i = Console.ReadLine();
            if ((!int.TryParse(i, out j) == true))
            {
                Console.WriteLine("SKRIV ETT NUMMER!!!!");
                inventory.Beep();

            }
            //kollar att det är ett nummer, om inte ger användaren instruktioner att det är fel
        }
        //kör loopen tills användaren har skrivit ett nummer, sammt gör en try parse med answer och kollar att det går
        return j;
        //retunerar numret som j
    }
    //kollar så att det är ett nummer och inte text
    public int answer()
    {
        Console.WriteLine("");
        Console.WriteLine("Skriv ett nummer mellan 1-15");
        while (true)
        {
            int j = GetNummber();
            if (j > 0 && j < 16)
            {

                return j;
            }
            //kollar att numret är inom det angivna intervalet

            else
            {
                Console.WriteLine("SKRIV ETT NUMMER MELLAN 1-15!!!!");
                inventory.Beep();
            }
            //ger instruktioner ifall fel input
        }
    }
    //får ett answer och retunerar en int
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
}
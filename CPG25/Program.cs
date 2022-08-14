Console.WriteLine("Which color would you like to display?");
Console.WriteLine("1 - White?");
Console.WriteLine("2 - Black?");
Console.WriteLine("3 - Red?");
Console.WriteLine("4 - Orange?");
Console.WriteLine("5 - Yellow?");
Console.WriteLine("6 - Green?");
Console.WriteLine("7 - Blue?");
Console.WriteLine("8 - Purple?");
Console.WriteLine("9 - Custom?");

string input = Console.ReadLine();

Colors newColor = input switch
{
    "1" => Colors.White,
    "2" => Colors.Black,
    "3" => Colors.Red,
    "4" => Colors.Orange,
    "5" => Colors.Yellow,
    "6" => Colors.Green,
    "7" => Colors.Blue,
    "8" => Colors.Purple,
    "9" => GetColor(),
    _ => Colors.Black,
};

Console.WriteLine("Your color contains " + newColor._blue + " blue, " + newColor._green + " green, and " + newColor._red + " red.");

Colors GetColor()
{
    int blue = GetBlue();
    int green = GetGreen();
    int red = GetRed();

    return new Colors(blue, green, red);
}

int GetBlue()
{
    Console.WriteLine("How much blue should your color have?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int GetGreen()
{
    Console.WriteLine("How much green should your color have?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int GetRed()
{
    Console.WriteLine("How much red should your color have?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

class Colors
{
    public int _blue;
    public int _green;
    public int _red;

    public Colors(int blue, int green, int red)
    {
        _blue = blue;
        _green = green;
        _red = red;
    }

    public static Colors White = new Colors(255, 255, 255);
    public static Colors Black = new Colors(0, 0, 0);
    public static Colors Red = new Colors(0, 0, 255);
    public static Colors Orange = new Colors(0, 165, 255);
    public static Colors Yellow = new Colors(0, 255, 255);
    public static Colors Green = new Colors(0, 128, 0);
    public static Colors Blue = new Colors(255, 0, 0);
    public static Colors Purple = new Colors(128, 0, 128);
}
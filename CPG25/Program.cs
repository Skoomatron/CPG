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
input switch
{
    "1" => Colors.White,
    "2" => Colors.Black,
    "3" => Colors.Red,
    "4" => Colors.Orange,
    "5" => Colors.Yellow,
    "6" => Colors.Green,
    "7" => Colors.Blue,
    "8" => Colors.Purple,
    "9" => GetColor()
};

Colors GetColor()
{
    
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
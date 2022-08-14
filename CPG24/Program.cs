Console.WriteLine("Would you like to select custom coordinates?");
Console.WriteLine("Y - Yes");
Console.WriteLine("N - No");
string input = Console.ReadLine();
Point newPoint = input switch
{
    "Y" => GetCords(true),
    "N" => GetCords(false),
    _ => GetCords(false)
};

Console.WriteLine("The coordinates are (" + newPoint._xCord + ", " + newPoint._yCord + ").");

Point GetCords(bool check)
{
    if (check)
    {
        int yCord = GetY();
        int xCord = GetX();
        return new Point(yCord, xCord);
    }
    else
    {
        return new Point();
    }
  
}
int GetX()
{
    Console.WriteLine("What is the X coordinate?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int GetY()
{
    Console.WriteLine("What is the Y coordinate?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}



class Point
{
    public int _xCord;
    public int _yCord;

    public Point()
    {
        _xCord = 1;
        _yCord = 0;
    }

    public Point(int x, int y)
    {
        _xCord = x;
        _yCord = y;
    }
}
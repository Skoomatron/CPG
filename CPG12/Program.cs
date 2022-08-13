// divisible by 3 = fire
// divisible by 5 = electric
// divisible by both = combined blast

for (int x = 0; x <= 100; x++)
{
    if (x % 3 == 0 && x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("COMBINED BLAST at crank " + x);
    } else if (x % 3 == 0 && x % 5 != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("FIRE BLAST at crank " + x);
    } else if (x % 5 == 0 && x % 3 != 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("ELECTRIC BLAST at crank " + x);
    }
}
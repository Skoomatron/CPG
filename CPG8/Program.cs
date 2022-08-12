Console.WriteLine("Please input a number.");
int tickTock = 0;
tickTock = Convert.ToInt32(Console.ReadLine());

if (tickTock % 2 == 0)
{
    Console.WriteLine("Tick!");
}
else
{
    Console.WriteLine("Tock!");
}
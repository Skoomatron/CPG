Console.WriteLine("What coordinates where the enemy spotted at?");
Console.WriteLine("Enter X coordinate.");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinate.");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("The Enemy is North East of us!");
} else if (x < 0 && y > 0)
{
    Console.WriteLine("The Enemy is North West of us!");
} else if (x > 0 && y < 0)
{
    Console.WriteLine("The Enemy is South East of us!");
} else if (x < 0 && y < 0)
{
    Console.WriteLine("The Enemy is South West of us!");
} else if (x == 0 && y > 0)
{
    Console.WriteLine("The Enemy is North of us!");
} else if (x == 0 && y < 0)
{
    Console.WriteLine("The Enemy is South of us!");
} else if (x > 0 && y == 0)
{
    Console.WriteLine("The Enemy is East of us!");
} else if (x < 0 && y == 0)
{
    Console.WriteLine("The Enemy is West of us!");
}
else
{
    Console.WriteLine("The enemy is upon us!");
}

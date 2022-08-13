void Recursion(int number)
{
    if (number == 0)
    {
        Console.WriteLine("You have reached 0");
        return;
    }

    number = number - 1;
    Recursion(number);
}

Recursion(10);


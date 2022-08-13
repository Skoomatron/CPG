int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(int min, int max, string text)
{
    int input;
    do
    {
        Console.WriteLine(text);
        input = Convert.ToInt32(Console.ReadLine());
    } while (input > max || input < min);

    return input;
}
int result = AskForNumber("Please submit a number.");
int askRange = AskForNumberInRange(0, 10, "Please guess a number in range.");

Console.WriteLine(result);
Console.WriteLine(askRange);
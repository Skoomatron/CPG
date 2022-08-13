Chest magicChest = Chest.locked;
bool forever = true;
string answer;

do
{
    if (magicChest == Chest.locked)
    {
        Console.WriteLine("The chest is locked, would you like to unlock it?");
        answer = Console.ReadLine();
        if (answer == "Yes")
        {
            magicChest = Chest.unlocked;
        }
        else
        {
            magicChest = Chest.locked;
        }
    } else if (magicChest == Chest.unlocked)
    {
        Console.WriteLine("The Magic Chest is unlocked, would you like to open it?");
        answer = Console.ReadLine();
        if (answer == "Yes")
        {
            magicChest = Chest.opened;
        }
        else
        {
            magicChest = Chest.unlocked;
        }
    } else if (magicChest == Chest.opened)
    {
        Console.WriteLine("The Magic Chest is opened, would you like to close it?");
        answer = Console.ReadLine();
        if (answer == "Yes")
        {
            magicChest = Chest.closed;
        }
        else
        {
            magicChest = Chest.opened;
        }
    } else if (magicChest == Chest.closed)
    {
        Console.WriteLine("The Magic Chest is closed, would you like to lock it?");
        answer = Console.ReadLine();
        if (answer == "Yes")
        {
            magicChest = Chest.locked;
        }
        else
        {
            magicChest = Chest.closed;
        }
    }
} while (forever == true);


enum Chest
{
    locked,
    unlocked,
    opened,
    closed
}
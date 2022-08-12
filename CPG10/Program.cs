Console.WriteLine("Welcome back traveler, what is your name?");
string name = Console.ReadLine();
Console.WriteLine("The following items are available at the shop -");
Console.WriteLine("1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");
Console.WriteLine("Which item would you like to see the price for?");
int selection = Convert.ToInt32(Console.ReadLine());

switch (name)
{
    case "Trevor":
        switch (selection)
        {
            case 1: 
                Console.WriteLine("The Rope costs 5 gold!");
                break; ;
            case 2:
                Console.WriteLine("The Torches cost 7 gold!");
                break;
            case 3:
                Console.WriteLine("The Climbing Equipment costs 12 gold!");
                break;
            case 4:
                Console.WriteLine("The Clean Water costs 1 gold!");
                break;
            case 5:
                Console.WriteLine("The Machete costs 10 gold!");
                break;
            case 6:
                Console.WriteLine("The Canoe costs 50 gold!");
                break;
            case 7:
                Console.WriteLine("The Food Supplies cost 1 gold!");
                break;
        }
        break;
    default:
        switch (selection)
        {
            case 1: 
                Console.WriteLine("The Rope costs 10 gold!");
                break; ;
            case 2:
                Console.WriteLine("The Torches cost 15 gold!");
                break;
            case 3:
                Console.WriteLine("The Climbing Equipment costs 25 gold!");
                break;
            case 4:
                Console.WriteLine("The Clean Water costs 1 gold!");
                break;
            case 5:
                Console.WriteLine("The Machete costs 20 gold!");
                break;
            case 6:
                Console.WriteLine("The Canoe costs 100 gold!");
                break;
            case 7:
                Console.WriteLine("The Food Supplies cost 1 gold!");
                break;
        }
        break;
}

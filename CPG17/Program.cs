// airship range input by player 1 0 - 100
// clear console
// player 2 repeatedly picks range
    // either too short, too long, or hit are reported back
    // normal turns do 1 damage
    // turns divisible by 3 or 5 do 3 damage
    // combined blasts do 10
// airship health is 10
    // airship does 1 damage per turn
// city health is 15
// every round updates game status

Console.Title = "Battle of the Manticore!";

int manticoreCurrent = 10;
int cityCurrent = 15;
int distance;
int playerGuess;
int round = 1;

Console.WriteLine("Player 1 - How far away is the Manticore?");
distance = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int AttackType(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        return 10;
    } else if (round % 3 == 0 && round % 5 != 0)
    {
        return 3;
    } else if (round % 3 != 0 && round % 5 == 0)
    {
        return 3;
    }
    else
    {
        return 1;
    }
}

string RangeCheck(int guess)
{
    if (guess > distance)
    {
        return "You overshot the target!";
    } else if (guess < distance)
    {
        return "You undershot the target!";
    }
    else
    {
        int damage = AttackType(round);
        manticoreCurrent = manticoreCurrent - damage;
        return "IT'S A HIT FOR " + damage + " DAMAGE!";
    }
}

do
{
    string response;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("STATUS: Round: " + round + " City Health: " + cityCurrent + "/15 Manticore Health: " + manticoreCurrent + "/10");
    int damage = AttackType(round);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("The cannon is expected to do " + damage + " this turn!");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Player 2 enter your desired cannon range!");
    playerGuess = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(RangeCheck(playerGuess));
    round++;
    cityCurrent--;
    if (cityCurrent <= 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You failed to protect the city, all is lost!");
        break;
    } else if (manticoreCurrent <= 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You sunk the Manticore!  The people rejoice!");
        break;
    }
}
while (cityCurrent > 0 || manticoreCurrent > 0);
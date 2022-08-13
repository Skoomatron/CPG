int pilotNumber;
do
{
    Console.WriteLine("Would you, the Pilot, guess a number between 0-100?");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
}
while (pilotNumber < 0 || pilotNumber > 100);

Console.Clear();

int hunterGuess;

do
{
    Console.WriteLine("Hunter!  Guess the pilot's number!");
    hunterGuess = Convert.ToInt32(Console.ReadLine());
    if (hunterGuess > pilotNumber)
    {
        Console.WriteLine("You guessed too high Hunter!");
    } else if (hunterGuess < pilotNumber)
    {
        Console.WriteLine("You guessed too low Hunter!");
    }
}
while (hunterGuess != pilotNumber);

Console.WriteLine("Hunter you have discovered the Pilot's number!");
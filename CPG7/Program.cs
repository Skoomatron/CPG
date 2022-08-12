Console.Title = "Defense of the Kingdom!";

int targetRow = 0;
int targetColumn = 0;

Console.WriteLine("What is the target X cooridinate?");
targetRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the target Y cooridinate?");
targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine("Deploy to ");
Console.WriteLine("(" + (targetColumn - 1) + ", " + targetRow + ")");
Console.WriteLine("(" + targetColumn + ", " + (targetRow + 1) + ")");
Console.WriteLine("(" + targetColumn + ", " + (targetRow - 1) + ")");
Console.WriteLine("(" + (targetColumn + 1) + ", " + targetRow + ")");

Console.Beep();
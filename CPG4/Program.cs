Console.WriteLine("What is the triangle base length?");
float triangleBase = 0.0f;
triangleBase = Single.Parse(Console.ReadLine());
Console.WriteLine("What is the triangle height?");
float triangleHeight = 0.0f;
triangleHeight = Single.Parse(Console.ReadLine());
float result = (triangleBase * triangleHeight) / 2;
Console.WriteLine("The Triangle's area is " + result + ".");
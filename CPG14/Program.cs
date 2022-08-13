int[] testArray = new int[5] {3, 2, 1, 4, 5};
float average;
int minimum = testArray[0];
int total = 0;

foreach (int index in testArray)
{
    total += index;
    if (index < minimum)
    {
        minimum = index;
    }
}
average = total / testArray.Length;

Console.WriteLine("Your average is " + average);
Console.WriteLine("Your minimum is " + minimum);

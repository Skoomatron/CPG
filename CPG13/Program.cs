int[] originalArray = new int[5];
int[] copiedArray = new int[5];

int submittedNumber;

for (int x = 0; x < originalArray.Length; x++)
{
    Console.WriteLine("Please input a number.");
    submittedNumber = Convert.ToInt32(Console.ReadLine());
    originalArray[x] = submittedNumber;
}

copiedArray = originalArray[0..5]; 

for (int x = 0; x <= originalArray.Length - 1; x++)
{
    Console.WriteLine("The original Array contains " + originalArray[x]);
    Console.WriteLine("The copied Array contains " + copiedArray[x]);
}
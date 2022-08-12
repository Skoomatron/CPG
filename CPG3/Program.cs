// 0 to 255
byte firstVariable = 1;
firstVariable = 3;
// -32,768 to 32,767
short secondVariable = -20_000;
secondVariable = 15_000;
// -2,147,483,648 to 2,147,483,647
int thirdVariable = 2_000_000;
thirdVariable = 1_000_000;
// -9,223,372,036,854,775,808 t0 9,223,372,036,854,775,807
long fourthVariable = 2_000_000_000_000;
fourthVariable = 3_000_000_000_000;
// -128 to 127
sbyte fithVariable = 125;
fithVariable = 122;
// 0 to 65,535
ushort sixthVariable = 65_000;
sixthVariable = 61_000;
// 0 to 4,294,967,295
uint seventhVariable = 4_000_000_000;
seventhVariable = 2_000_000_000;
// 0 to 18,446,744,073,709,551,615
ulong eigthVariable = 18_000_000_000_000_000_000;
eigthVariable = 12_000_000_000_000_000;
float ninthVariable = 18.12343242F;
ninthVariable = 12.213F;
double tenthVariable = 10_000.234535f;
tenthVariable = 12_000.32f;
decimal eleventhVariable = 7_432.12m;
eleventhVariable = 6_323.13m;
bool twelthVariable = false;
twelthVariable = true;
string thirteenthVariable = "A good day to die";
thirteenthVariable = "Not today junior";
char lastVariable = '\u0061';
lastVariable = '\u0032';

Console.WriteLine(firstVariable);
Console.WriteLine(secondVariable);
Console.WriteLine(thirdVariable);
Console.WriteLine(fourthVariable);
Console.WriteLine(fithVariable);
Console.WriteLine(sixthVariable);
Console.WriteLine(seventhVariable);
Console.WriteLine(eigthVariable);
Console.WriteLine(ninthVariable);
Console.WriteLine(tenthVariable);
Console.WriteLine(eleventhVariable);
Console.WriteLine(twelthVariable);
Console.WriteLine(thirteenthVariable);
Console.WriteLine(lastVariable);


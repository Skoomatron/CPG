byte sisters = 4;
Console.WriteLine("How many eggs did the sisters collect today?");
byte eggsCollected = 0;
eggsCollected = Byte.Parse(Console.ReadLine());
float duckbearEggs = eggsCollected % sisters;
float sisterEggs = (eggsCollected - duckbearEggs) / sisters;
Console.WriteLine("The duckbear gets " + duckbearEggs + " eggs, the sisters each get " + sisterEggs + ".");
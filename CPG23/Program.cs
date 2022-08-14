Console.WriteLine("What arrow do you want?");
Console.WriteLine("1 - Elite Arrow");
Console.WriteLine("2 - Beginner Arrow");
Console.WriteLine("3 - Marksman Arrow");
Console.WriteLine("4 - Custom Arrow");

int choice = Convert.ToInt32(Console.ReadLine());

Arrow newArrow = choice switch
{
    1 => Arrow.CreateEliteArrow(),
    2 => Arrow.CreateBeginnerArrow(),
    3 => Arrow.CreateMarksmanArrow(),
    _ => CreateCustomArrow(),
};

Console.WriteLine($"That arrow costs {newArrow.GetCost} gold.");

Arrow CreateCustomArrow()
{
    ArrowTypes arrowTypes = SelectArrow();
    FeatherTypes featherTypes = SelectFeather();
    int arrowLength = SelectLength();

    return new Arrow(arrowTypes, featherTypes, arrowLength);
}

ArrowTypes SelectArrow()
{
    Console.WriteLine("Which arrow would you like: (steel, obsidian, wood)?");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => ArrowTypes.steel,
        "obsidian" => ArrowTypes.obsidian,
        "wood" => ArrowTypes.wood
    };
}

FeatherTypes SelectFeather()
{
    Console.WriteLine("Which feather would you like: (goose, turkey, plastic)?");
    string input = Console.ReadLine();
    return input switch
    {
        "goose" => FeatherTypes.goose,
        "turkey" => FeatherTypes.turkey,
        "plastic" => FeatherTypes.plastic,
    };
}

int SelectLength()
{
    Console.WriteLine("How long would you like the arrow?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
public class Arrow
{
    public ArrowTypes ArrowTypes { get; }
    public FeatherTypes FeatherTypes { get; }
    public int Length { get; }

    public Arrow(ArrowTypes arrowTypes, FeatherTypes featherTypes, int arrowLength)
    {
        ArrowTypes = arrowTypes;
        FeatherTypes = featherTypes;
        Length = arrowLength;

    }

    public static Arrow CreateEliteArrow() => new Arrow(ArrowTypes.steel, FeatherTypes.plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowTypes.wood, FeatherTypes.goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowTypes.steel, FeatherTypes.goose, 65);
    
    public int GetCost
    {
        get
        {
            int typeCost = ArrowTypes switch
            {
                ArrowTypes.steel => 5,
                ArrowTypes.obsidian => 10,
                ArrowTypes.wood => 1,
            };
            int featherCost = FeatherTypes switch
            {
                FeatherTypes.goose => 10,
                FeatherTypes.turkey => 5,
                FeatherTypes.plastic => 1,
            };
            int shaftCost = 1 * Length;

            return typeCost + featherCost + shaftCost;
        }
    }
}
public enum ArrowTypes
{
    steel,
    wood,
    obsidian
}

public enum FeatherTypes
{
    goose,
    turkey,
    plastic,
}
Arrow newArrow = GetArrow();
Console.WriteLine($"Your new arrow costs {newArrow.GetCost()} gold.");


Arrow GetArrow()
{
    ArrowType arrowType = GetArrowType();
    FeatherType featherType = GetFeatherType();
    int arrowLength = GetArrowLength();

    return new Arrow(arrowType, featherType, arrowLength);
}

ArrowType GetArrowType()
{
    Console.WriteLine("Select and arrow type: (steel, obsidian, wood)");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => ArrowType.steel,
        "obsidian" => ArrowType.obsidian,
        "wood" => ArrowType.wood
    };
}

FeatherType GetFeatherType()
{
    Console.WriteLine("Select a feather type: (goose, turkey, plastic)");
    string input = Console.ReadLine();
    return input switch
    {
        "goose" => FeatherType.goose,
        "turkey" => FeatherType.turkey,
        "plastic" => FeatherType.plastic
    };
}

int GetArrowLength()
{
    Console.WriteLine("Select and arrow length.");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


class Arrow
{
    private ArrowType _arrowType;
    private FeatherType _featherType;
    private int _arrowLength;

    public ArrowType GetArrowType() => _arrowType;
    public FeatherType GetFeatherType() => _featherType;
    public int GetArrowLength() => _arrowLength;
    
    public Arrow(ArrowType arrowType, FeatherType featherType, int arrowLength)
    {
        _arrowLength = arrowLength;
        _featherType = featherType;
        _arrowType = arrowType;
    }

    public int GetCost()
    {
        int typeCost = _arrowType switch
        {
            ArrowType.steel => 5,
            ArrowType.obsidian => 10,
            ArrowType.wood => 1,
        };
        int featherCost = _featherType switch
        {
            FeatherType.goose => 10,
            FeatherType.turkey => 5,
            FeatherType.plastic => 1
        }; 
        
        int lengthCost = _arrowLength * 2;
        
        int total = typeCost + featherCost + lengthCost;
        return total;
    }
}
enum ArrowType
{
    steel,
    wood,
    obsidian
}

enum FeatherType
{
    goose,
    turkey,
    plastic
}
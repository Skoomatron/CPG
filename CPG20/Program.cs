Arrow arrow = GetArrow();
Console.WriteLine($"Your new arrow costs {arrow.GetCost()} gold.");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowType();
    Fletching fletching = GetFletching();
    int shaft = GetLength();

    return new Arrow(arrowhead, fletching, shaft);
}
Arrowhead GetArrowType()
{
    Console.WriteLine("Which arrowhead would you like: (steel, wood, obsidian) ?");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => Arrowhead.steel,
        "wood" => Arrowhead.wood,
        "obsidian" => Arrowhead.obsidian
    };
}

Fletching GetFletching()
{
    Console.WriteLine("Which feather type would you like: (plastic, turkey, goose) ?");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.plastic,
        "turkey" => Fletching.turkeyFeather,
        "goose" => Fletching.plastic
    };
}

int GetLength()
{
    Console.WriteLine("How long would you like your arrow?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
class Arrow
{
    public Arrowhead _arrowhead;
    public Fletching _fletching;
    public int _shaft;

    public Arrow(Arrowhead arrowhead, Fletching fletching, int shaft)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _shaft = shaft;
    }

    public float GetCost()
    {
        int headCost = _arrowhead switch
        {
            Arrowhead.steel => 5,
            Arrowhead.obsidian => 10,
            Arrowhead.wood => 1
        };
        int featherCost = _fletching switch
        {
            Fletching.plastic => 1,
            Fletching.turkeyFeather => 5,
            Fletching.gooseFeather => 10
        }; 
        
        float shaftCost = 0.05f * _shaft;

        return headCost + featherCost + shaftCost;
    }
}

enum Arrowhead
{
    steel,
    wood,
    obsidian
}

enum Fletching
{
    plastic,
    turkeyFeather,
    gooseFeather,
}
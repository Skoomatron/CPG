(FoodType food, MainIngredient ingredient, Seasoning season) soup = GetSoup();
Console.WriteLine($"{soup.season} {soup.ingredient} {soup.food}");

(FoodType, MainIngredient, Seasoning) GetSoup()
{
    FoodType food = GetFoodType();
    MainIngredient ingredient = GetMainIngredient();
    Seasoning season = GetSeasoning();
    return (food, ingredient, season);
}

FoodType GetFoodType()
{
    Console.Write("Soup Types (soup, stew, gumbo): ");
    string input = Console.ReadLine();
    return input switch
    {
        "soup" => FoodType.soup,
        "stew" => FoodType.stew,
        "gumbo" => FoodType.gumbo,
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Seasoning Types (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.spicy,
        "salty" => Seasoning.salty,
        "sweet" => Seasoning.sweet,
    };
}

MainIngredient GetMainIngredient()
{
    Console.Write("Soup Types (mushroom, chicken, carrot, potato): ");
    string input = Console.ReadLine();
    return input switch
    {
        "mushroom" => MainIngredient.mushrooms,
        "chicken" => MainIngredient.chicken,
        "carrot" => MainIngredient.carrots,
        "potato" => MainIngredient.potatoes
    };
}
enum FoodType
{
    soup,
    stew,
    gumbo
}

enum MainIngredient
{
    mushrooms,
    chicken,
    carrots,
    potatoes
}

enum Seasoning
{
    spicy,
    salty,
    sweet
}
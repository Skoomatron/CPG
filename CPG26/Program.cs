Card newCard = new Card();
Console.WriteLine("What type of card is the current card?");
Console.WriteLine(newCard.CheckRank(newCard._cardRank));


class Card
{
    public CardColors _cardColor;
    public CardRanks _cardRank;

    public Card()
    {
        _cardColor = CardColors.blue;
        _cardRank = CardRanks.one;
    }
    public Card(CardColors color, CardRanks rank)
    {
        _cardColor = color;
        _cardRank = rank;
    }
    public string CheckRank(CardRanks rank)
    {
        if (rank == CardRanks.ampersand || rank == CardRanks.dollar || rank == CardRanks.exponent ||
            rank == CardRanks.percent)
        {
            return "Power Card!";
        }
        else
        {
            return "Number Card.";
        }
    }
    
}
enum CardColors
{
    red,
    blue,
    green,
    yellow
}

enum CardRanks
{
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    ten,
    dollar,
    percent,
    exponent,
    ampersand
}
namespace DesignPatterns.Observer
{
  record Card
  {
    public CardSuitInfo Suit { get; }
    public CardName Name { get; }

    public Card(CardSuitInfo suit, CardName name)
    {
      this.Suit = suit;
      this.Name = Name;
    }
  }
}
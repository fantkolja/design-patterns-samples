namespace DesignPatterns.Observer
{
  record CardSuitInfo
  {
    public CardSuit Id { get; }
    public string Name { get; }
    public char Icon { get; }

    private CardSuitInfo(CardSuit id, string name, char icon)
    {
      this.Id = id;
      this.Name = name;
      this.Icon = icon;
    }
    public static Dictionary<CardSuit, CardSuitInfo> SuitMap = new Dictionary<CardSuit, CardSuitInfo>(){
      { CardSuit.Diamonds, new CardSuitInfo(CardSuit.Diamonds, "Diamonds", '♦') },
      { CardSuit.Clubs, new CardSuitInfo(CardSuit.Clubs, "Clubs", '♣') },
      { CardSuit.Hearts, new CardSuitInfo(CardSuit.Hearts, "Hearts", '♥') },
      { CardSuit.Spades, new CardSuitInfo(CardSuit.Spades, "Spades", '♠') },
    };
  }
}
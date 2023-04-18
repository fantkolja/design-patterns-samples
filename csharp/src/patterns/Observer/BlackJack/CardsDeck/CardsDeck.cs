namespace DesignPatterns.Observer
{
  class CardsDeck
  {
    private Queue<Card> _cardsIn = new Queue<Card>();
    private List<Card> _cardsOut = new List<Card>();
    private static List<Card> _createDeck()
    {
      List<Card> cards = new List<Card>();
      foreach(CardSuit suit in Enum.GetValues(typeof(CardSuit)))
      {
        CardSuitInfo suitInfo = CardSuitInfo.SuitMap[suit];
        foreach(CardName name in Enum.GetValues(typeof(CardName)))
        {
          cards.Add(new Card(suitInfo, name));
        }
      }
      return cards;
    }
    public CardsDeck()
    {
      this.Shaffle();
    }
    private static List<T> _randomizeOrder<T>(List<T> list)
    {
      List<T> shuffledList = new List<T>(list);
      Random rng = new Random();
      int n = shuffledList.Count;
      while (n > 1) {  
          n--;  
          int k = rng.Next(n + 1);  
          T value = shuffledList[k];  
          shuffledList[k] = shuffledList[n];  
          shuffledList[n] = value;  
      }
      return shuffledList;
    }
    public void Shaffle()
    {
      List<Card> cards = CardsDeck._randomizeOrder<Card>(CardsDeck._createDeck());
      this._cardsIn = new Queue<Card>(cards);
      this._cardsOut = new List<Card>();
    }
    public Card Draw()
    {
      Card card = this._cardsIn.Dequeue();
      this._cardsOut.Add(card);
      return card;
    }
  }
}
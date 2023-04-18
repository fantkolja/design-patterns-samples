namespace DesignPatterns.Observer
{
  static class Logger
  {
    public static void Greet()
    {
      Console.WriteLine("===========================");
      Console.WriteLine("Hello, let's play BlackJack");
      Console.WriteLine("===========================");
      Console.WriteLine("");
    }
    public static void StartPlayersTurn(string playerName)
    {
      Console.WriteLine($"Now it's {playerName}'s turn!");
      Console.WriteLine($"Get ready");
      Console.WriteLine("");
    }
    public static void ShowDrawnCard(Card card, int totalPointsCount)
    {
      Console.WriteLine($"You have drawn {card.Name} of {card.Suit.Name}");
      Console.WriteLine($"Your total points count is: {totalPointsCount}");
      Console.WriteLine("");
    }
    public static void ShownCardShortInfo(Card card)
    {
      Console.WriteLine($"{card.Name} {card.Suit.Icon}");
    }
    public static void ShowPlayerSwitchMessage(string playerName)
    {
      Console.WriteLine($"Switching to player {playerName}...");
    }
    public static void EndGame(List<Player> winners)
    {
      Console.WriteLine("Checking winners...");
      if (winners.Count == 0)
      {
        Console.WriteLine("You are all LOSERS!!! :)");
      }
      else if (winners.Count == 1)
      {
        Console.WriteLine($"The absolute winner is {winners[0].Name}");
      }
      else
      {
        string names = String.Join(", ", winners.Select((player) => player.Name));
         Console.WriteLine($"The winners are {names}");
      }
    }
    public static void Log(string message)
    {
      Console.WriteLine(message);
    }
  }
}
namespace ProgrammingPrinciples.KISS
{
  class Samples
  {
    // BAD practice: Unnecessary complexity
    public static void PrintNumbersRecursively(int number)
    {
        if (number >= 0) 
        {
            PrintNumbersRecursively(number - 1);
            Console.WriteLine(number);
        }
    }


    //GOOD Practice: Keeping it simple
    public static void PrintNumbersLoop(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }











    public class Player
    {
      public bool IsOnline;
      public string? CurrentGame;

      public List<string> PendingInvitations = new List<string>();
    }



    // BAD: Deeply nested and hard to understand
    public static string GetPlayerStatus_BAD(Player player)
    {
        if (player.IsOnline) {
            if (player.CurrentGame != null) {
                return "Player is currently in a game";
            } else {
                if (player.PendingInvitations.Count > 0) {
                    return "Player has pending invitations";
                } else {
                    return "Player is online";
                }
            }
        } else {
            return "Player is offline";
        }
    }

    // GOOD: Reduced nesting and more readable
    public string GetPlayerStatus(Player player)
    {
        if (!player.IsOnline)
            return "Player is offline";

        if (player.CurrentGame != null)
            return "Player is currently in a game";

        return (player.PendingInvitations.Count > 0) ? "Player has pending invitations" : "Player is online";
    }
  }
}
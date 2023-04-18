namespace DesignPatterns.Observer
{
  class GameState
  {
    private List<Player> _players = new List<Player>();
    public CardsDeck Deck { get; } = new CardsDeck();
    public Player? ActivePlayer { get; private set; }

    public List<Player> GetWinners()
    {
      return this._players.Aggregate(new List<Player>(), (List<Player> winners, Player next) => {
        int? nextPlayerPointsCount = PointsCounter.CountWinningPoints(next.DrawnCards);
        int? currentWinningPoints = winners.Count > 0 ? PointsCounter.CountWinningPoints(winners[0].DrawnCards) : null;
        if (nextPlayerPointsCount is int)
        {
          // if there is no winner yet
          if (currentWinningPoints == null)
          {
            winners.Add(next);
          }
          // if the points count is the same
          if (nextPlayerPointsCount == currentWinningPoints)
          {
            winners.Add(next);
          }
          // if next player has more points
          if (nextPlayerPointsCount > currentWinningPoints)
          {
            winners.Clear();
            winners.Add(next);
          }
        }
        return winners;
      });
    }
    public void SetPlayers(List<Player> players)
    {
      this._players.AddRange(players);
      this.ActivePlayer = this._players[0];
    }

    public bool SwitchPlayer()
    {
      bool hasSwitchedToNewPlayer = false;
      int activePlayerIndex = this.ActivePlayer == null ? -1 : this._players.IndexOf(this.ActivePlayer);
      if (activePlayerIndex > -1 && activePlayerIndex < this._players.Count - 1)
      {
        this.ActivePlayer = this._players[++activePlayerIndex];
        Logger.ShowPlayerSwitchMessage(this.ActivePlayer.Name);
        hasSwitchedToNewPlayer = true;
      }
      return hasSwitchedToNewPlayer;
    }
  }
}
namespace DesignPatterns.Observer
{
  class Game
  {
    public static readonly int PLAYER_COUNT = 2;
    public static readonly int CARDS_WITHOUT_CONFIRMATION_COUNT = 2;
    private GameState _state = new GameState();
    private List<Player> _createPlayers()
    {
      var players = new List<Player>();
      for (int i = 1; i <= PLAYER_COUNT; i++)
      {
        string defaultName = $"Player {i}";
        string name = InputHandler.RequestAnswer($"Write a name for [{defaultName}]", defaultName);
        players.Add(new Player(name));
      }
      return players;
    }
    private void _greet()
    {
      Logger.Greet();
    }
    private void _initiateState()
    {
      this._state.SetPlayers(this._createPlayers());
    }
    public void Start()
    {
      this._greet();
      this._initiateState();
      do
      {
        if (this._state.ActivePlayer == null)
        {
          throw new Exception("No active player detected!");          
        }
        this.HandlePlayer(this._state.ActivePlayer);
      }
      while(this._state.SwitchPlayer());
      this.End();
    }

    public void End()
    {
      List<Player> winners = this._state.GetWinners();
      Logger.EndGame(winners);
    }

    public void HandlePlayer(Player player)
    {
      Logger.StartPlayersTurn(player.Name);
      for (int i = 0; i < CARDS_WITHOUT_CONFIRMATION_COUNT; i++)
      {
        player.DrawCard(this._state.Deck);
      }
      while (PointsCounter.CountSum(player.DrawnCards) < PointsCounter.MAX_POINTS_COUNT && player.ConfirmNextDraw())
      {
        player.DrawCard(this._state.Deck);
      }
    }
  }
}
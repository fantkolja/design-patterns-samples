namespace DesignPatterns.Command
{
  class Command
  {
    public Action Execute { get; set; }
    public Action Undo { get; set; }

    public Command(Action execute)
    : this(execute, delegate {}) {}

    public Command(Action execute, Action undo)
    {
      this.Execute = execute;
      this.Undo = undo;
    }
  }

  class Remote
  {
    private List<Action> _actions = new List<Action>();
  }
}
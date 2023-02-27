namespace DesignPatterns.Memento
{
  class ClassicConcreteMemento : IClassicMemento
  {
    // immutable as the rule
    private int _state;

    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Date { get; } = DateTime.Now;

    public ClassicConcreteMemento(int state)
    {
      this._state = state;
    }

    public int GetState()
    {
      return this._state;
    }
  }
}
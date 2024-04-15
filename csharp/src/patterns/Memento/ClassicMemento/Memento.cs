namespace DesignPatterns.Memento
{
  class Memento : IMemento
  {
    private readonly int _state;

    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Date { get; } = DateTime.Now;

    public Memento(int state)
    {
      this._state = state;
    }

    public int GetState()
    {
      return this._state;
    }
  }
}



























// Version #2: Strict Encapsulation
// namespace DesignPatterns.Memento
// {
//   class Memento : IMemento
//   {
//     // immutable as the rule
//     private readonly int _state;
//     private Originator _originator;

//     public Guid Id { get; } = Guid.NewGuid();
//     public DateTime Date { get; } = DateTime.Now;

//     public Memento(Originator originator, int state)
//     {
//       this._originator = originator;
//       this._state = state;
//     }

//     public void Restore()
//     {
//       this._originator.SetState(this._state);
//     }
//   }
// }
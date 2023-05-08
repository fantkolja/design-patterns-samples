namespace DesignPatterns.Memento
{
  class ClassicMemento : IClassicMemento
  {
    // immutable as the rule
    private int _state;

    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Date { get; } = DateTime.Now;

    public ClassicMemento(int state)
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
//   class ClassicMemento : IClassicMemento
//   {
//     // immutable as the rule
//     private int _state;
//     private ClassicOriginator _originator;

//     public Guid Id { get; } = Guid.NewGuid();
//     public DateTime Date { get; } = DateTime.Now;

//     public ClassicMemento(ClassicOriginator originator, int state)
//     {
//       this._originator = originator;
//       this._state = state;
//     }

//     public void Restore()
//     {
//       this._originator.Restore(this);
//     }
//   }
// }
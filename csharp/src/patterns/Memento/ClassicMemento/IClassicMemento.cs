namespace DesignPatterns.Memento
{
  // can be empty at all
  // interface IClassicMemento
  // {
  //   public Guid Id { get; }
  //   public DateTime Date { get; }
  // }












  // Version #2: Strict Encapsulation
  interface IClassicMemento
  {
    public Guid Id { get; }
    public DateTime Date { get; }
    public void Restore();
  }
}
namespace DesignPatterns.Memento
{
  // can be empty at all
  interface IClassicMemento
  {
    public Guid Id { get; }
    public DateTime Date { get; }
  }


  // can be a class
  // but without a constructor because cannot be public
  // class ClassicMemento
  // {
  //   public Guid Id { get; } = Guid.NewGuid();
  //   public DateTime Date { get; } = DateTime.Now;
  // }












  // Version #2: Strict Encapsulation
  // interface IClassicMemento
  // {
  //   public Guid Id { get; }
  //   public DateTime Date { get; }
  //   public void Restore();
  // }
}
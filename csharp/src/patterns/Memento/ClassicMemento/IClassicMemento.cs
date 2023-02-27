namespace DesignPatterns.Memento
{
  // can be empty at all
  interface IClassicMemento
  {
    Guid Id { get; }
    DateTime Date { get; }
  }


  // can be a class
  // but withput a constructor because cannot be public
  // class ClassicMemento
  // {
  //   Guid Id { get; } = Guid.NewGuid();
  //   DateTime Date { get; } = DateTime.Now;
  // }
}
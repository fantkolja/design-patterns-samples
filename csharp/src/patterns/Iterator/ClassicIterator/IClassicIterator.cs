namespace DesignPatterns.Iterator
{
  interface IClassicIterator
  {
    public object? Next();
    public object? Current();
    public bool IsDone();
    public void Reset();
  }
}

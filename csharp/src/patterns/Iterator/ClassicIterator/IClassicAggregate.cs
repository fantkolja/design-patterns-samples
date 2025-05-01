namespace DesignPatterns.Iterator
{
  interface IClassicAggregate<T>
  {
    public IClassicIterator<T> GetIterator();
  }
}

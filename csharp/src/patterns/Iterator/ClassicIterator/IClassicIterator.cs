namespace DesignPatterns.Iterator
{
  interface IClassicIterator<T>
  {
    bool MoveNext();
    T? Current { get; }
    void Reset();
  }
}

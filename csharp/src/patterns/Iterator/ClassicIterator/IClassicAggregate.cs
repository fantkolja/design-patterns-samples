namespace DesignPatterns.Iterator
{
  interface IClassicAggregate
  {
    public IClassicIterator GetIterator();
  }
}


// public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
// {
//   throw new System.NotImplementedException();
//   yield return default(ElementType);
// }
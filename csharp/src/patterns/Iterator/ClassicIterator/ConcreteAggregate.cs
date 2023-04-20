using System.Reflection;

namespace DesignPatterns.Iterator
{
  class ConcreteAggregate : IClassicAggregate
  {
    public string X { get; set; } = "x";
    public string Fak { get; set; } = "fak";
    public string F { get; set; } = "f";
    public string A { get; set; } = "a";
    public string B { get; set; } = "b";
    public string C { get; set; } = "c";

    public IClassicIterator GetIterator()
    {
      return new AlphabeticalIterator(this);
    }

    public class AlphabeticalIterator : IClassicIterator
    {
      private ConcreteAggregate _aggregate;
      private List<PropertyInfo> _aggregateProperties
      {
        get
        {
          List<PropertyInfo> propList = this._aggregate
            .GetType()
            .GetProperties()
            .ToList();
          propList.Sort((PropertyInfo prop1, PropertyInfo prop2) => String.Compare(prop1.Name, prop2.Name, StringComparison.Ordinal));
        return propList;
        }
      }
      private int _cursor = -1;
      public AlphabeticalIterator(ConcreteAggregate aggregate)
      {
        this._aggregate = aggregate;
        
      }
      public object? Current()
      {
        return this._cursor > -1 ? this._aggregateProperties[this._cursor].GetValue(this._aggregate) : null;
      }

      public bool IsDone()
      {
        return this._cursor + 1 == this._aggregateProperties.Count;
      }

      public object? Next()
      {
        return this.IsDone() ? null : this._aggregateProperties[++this._cursor].GetValue(this._aggregate);
      }

      public void Reset()
      {
        this._cursor = -1;
      }
    }
  }
}






// using DesignPatterns.Iterator;

// var aggregate = new ConcreteAggregate();
// var iterator = aggregate.GetIterator();
// logEach(iterator);

// static void logEach(IClassicIterator iterator)
// {
//   while(!iterator.IsDone())
//   {
//     Console.WriteLine(iterator.Next());
//   }
// }






// public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
// {
//   throw new System.NotImplementedException();
//   yield return default(ElementType);
// }
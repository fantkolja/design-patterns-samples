using System.Reflection;

namespace DesignPatterns.Iterator
{
  class AlphabeticalIterator : IClassicIterator<string>
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
    public string? Current => (string?)_aggregateProperties[_cursor].GetValue(_aggregate);

    public bool IsDone()
    {
      return this._cursor + 1 == this._aggregateProperties.Count;
    }

    public bool MoveNext()
    {
      _cursor++;
      return _cursor < _aggregateProperties.Count;
    }

    public void Reset()
    {
      this._cursor = -1;
    }
  }
}
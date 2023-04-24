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
//   };
// }





using DesignPatterns.Iterator;

var aggregate = new ConcreteAggregate();
logEach(aggregate);

static void logEach(IClassicAggregate<string> aggregate)
{
  var iterator = aggregate.GetIterator();
  while(iterator.MoveNext())
  {
    Console.WriteLine(iterator.Current);
  }
  iterator.Reset();
}


Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
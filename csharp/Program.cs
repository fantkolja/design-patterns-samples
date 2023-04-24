using DesignPatterns.Iterator;

var aggregate = new ConcreteAggregate();
var iterator = aggregate.GetIterator();
logEach(iterator);

static void logEach(IClassicIterator iterator)
{
  while(!iterator.IsDone())
  {
    Console.WriteLine(iterator.Next());
  };
}

var builtInList = new List<string>(){ "1", "2", "3", "4", "5" };
var builtInIterator = builtInList.GetEnumerator();

while(builtInIterator.MoveNext())
{
  Console.WriteLine(builtInIterator.Current);
};

Console.WriteLine("");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);



namespace DesignPatterns.Iterator;
class ConcreteAggregate : IClassicAggregate<string>
{
  public string X { get; set; } = "x";
  public string Fak { get; set; } = "fak";
  public string F { get; set; } = "f";
  public string A { get; set; } = "a";
  public string B { get; set; } = "b";
  public string C { get; set; } = "c";

  public IClassicIterator<string> GetIterator()
  {
    return new AlphabeticalIterator(this);
  }
}






// using DesignPatterns.Iterator;

// var aggregate = new ConcreteAggregate();
// logEach(aggregate);

// static void logEach(IClassicAggregate<string> aggregate)
// {
//   var iterator = aggregate.GetIterator();
//   while(iterator.MoveNext())
//   {
//     Console.WriteLine(iterator.Current);
//   }
//   iterator.Reset();
// }
































// class ConcreteAggregate
// {
//   public string X { get; set; } = "x";
//   public string Fak { get; set; } = "fak";
//   public string F { get; set; } = "f";
//   public string A { get; set; } = "a";
//   public string B { get; set; } = "b";
//   public string C { get; set; } = "c";

//   public IEnumerable<string> IterateAlphabetically()
//   {
//     yield return this.A;
//     yield return this.B;
//     yield return this.C;
//     yield return this.F;
//     yield return this.Fak;
//     yield return this.X;
//   }
// }

// using DesignPatterns.Iterator;

// var aggregate = new ConcreteAggregate();

// foreach (var item in aggregate.IterateAlphabetically())
// {
//     Console.WriteLine(item);
// }







// class ConcreteAggregate
// {
//   public string X { get; set; } = "x";
//   public string Fak { get; set; } = "fak";
//   public string F { get; set; } = "f";
//   public string A { get; set; } = "a";
//   public string B { get; set; } = "b";
//   public string C { get; set; } = "c";

//   async public IAsyncEnumerable<string> IterateAlphabetically()
//   {
//     yield return this.A;
//     yield return this.B;
//     await Task.Delay(3000);
//     yield return this.C;
//     yield return this.F;
//     yield return this.Fak;
//     yield return this.X;
//   }
// }

// using DesignPatterns.Iterator;

// var aggregate = new ConcreteAggregate();

// await foreach (var item in aggregate.IterateAlphabetically())
// {
//     Console.WriteLine(item);
// }
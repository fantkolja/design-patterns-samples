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
// logEach(aggregate);



// static void logEach(IClassicAggregate aggregate)
// {
//   var iterator = aggregate.GetIterator();
//   while(!iterator.IsDone())
//   {
//     Console.WriteLine(iterator.Next());
//   };
// }
































    // @todo: replace with IEnumerable 
    // public async IAsyncEnumerable<string> GetProps()
    // {
    //   yield return this.A;
    //   yield return this.B;
    //   await Task.Delay(3000);
    //   yield return this.C;
    //   yield return this.F;
    //   yield return this.Fak;
    //   yield return this.X;
    // }
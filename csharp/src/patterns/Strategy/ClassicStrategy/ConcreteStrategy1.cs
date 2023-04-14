namespace DesignPatterns.Strategy
{
  class ConcreteStrategy1 : IStrategy
  {
    public void Execute(int arg)
    {
      Console.WriteLine($"Do something with arg: {arg * 2}");
    }
  }
}
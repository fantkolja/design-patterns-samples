namespace DesignPatterns.Bridge
{
  class ConcreteImplementor1 : Implementor
  {
    public void DoSomethingA()
    {
      Console.WriteLine("Do something like a real 'A1'");
    }

    public void DoSomethingB()
    {
      Console.WriteLine("Do something like a real 'B1'");
    }
  }
}
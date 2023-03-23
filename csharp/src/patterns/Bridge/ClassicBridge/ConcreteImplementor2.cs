namespace DesignPatterns.Bridge
{
  class ConcreteImplementor2 : Implementor
  {
    public void DoSomethingA()
    {
      Console.WriteLine("Do something like a real 'A2'");
    }

    public void DoSomethingB()
    {
      Console.WriteLine("Do something like a real 'B2'");
    }
  }
}
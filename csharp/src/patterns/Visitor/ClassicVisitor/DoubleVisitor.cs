namespace DesignPatterns.Visitor
{
  class DoubleVisitor : IVisitor
  {
    public int Visit(ConcreteElement1 element)
    {
      Console.WriteLine("Applying DoubleVisitor to ConcreteElement1");
      return element.Prop * 2;
    }
    public int Visit(ConcreteElement2 element)
    {
      Console.WriteLine("Applying DoubleVisitor to ConcreteElement2");
      return element.Member * 2;
    }
  }
}
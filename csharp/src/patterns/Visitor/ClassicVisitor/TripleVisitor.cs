namespace DesignPatterns.Visitor
{
  class TripleVisitor : IVisitor
  {
    public int Visit(ConcreteElement1 element)
    {
      Console.WriteLine("Applying TripleVisitor to ConcreteElement1");
      return element.Prop * 3;
    }
    public int Visit(ConcreteElement2 element)
    {
      Console.WriteLine("Applying TripleVisitor to ConcreteElement2");
      return element.Member * 3;
    }
  }
}
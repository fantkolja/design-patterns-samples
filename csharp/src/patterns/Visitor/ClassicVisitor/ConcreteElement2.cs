namespace DesignPatterns.Visitor
{
  class ConcreteElement2 : IVisitable
  {
    public int Member = 2;
    public int Accept(IVisitor visitor)
    {
      return visitor.Visit(this);
    }
  }
}
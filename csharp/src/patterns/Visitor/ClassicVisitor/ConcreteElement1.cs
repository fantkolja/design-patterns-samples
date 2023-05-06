namespace DesignPatterns.Visitor
{
  class ConcreteElement1 : IVisitable
  {
    public int Prop = 1;
    public int Accept(IVisitor visitor)
    {
      return visitor.Visit(this);
    }
  }
}
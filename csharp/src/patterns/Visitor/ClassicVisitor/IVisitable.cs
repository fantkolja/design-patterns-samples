namespace DesignPatterns.Visitor
{
  interface IVisitable
  {
    public int Accept(IVisitor visitor);
  }
}
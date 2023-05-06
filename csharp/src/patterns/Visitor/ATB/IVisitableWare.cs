namespace DesignPatterns.Visitor
{
  interface IVisitableWare
  {
    public double Accept(IWareVisitor visitor);
  }
}
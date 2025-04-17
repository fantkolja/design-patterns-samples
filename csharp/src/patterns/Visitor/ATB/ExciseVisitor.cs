namespace DesignPatterns.Visitor
{
  class ExciseVisitor : IWareVisitor
  {
    public double Visit(Alcohol ware) => ware.Price * 1.4;
    public double Visit(Tobacco ware) => ware.Price * 1.2;
    public double Visit(MilkProduct ware) => ware.Price * 1;
  }
}
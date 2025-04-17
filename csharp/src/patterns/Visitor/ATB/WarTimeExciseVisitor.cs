namespace DesignPatterns.Visitor
{
  class WarTimeExciseVisitor : IWareVisitor
  {
    public double Visit(Alcohol ware) => ware.Price * 3;
    public double Visit(Tobacco ware) => ware.Price * 1.1;
    public double Visit(MilkProduct ware) => ware.Price * 1;
  }
}
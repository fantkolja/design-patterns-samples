namespace DesignPatterns.Visitor
{
  class WarTimeExciseVisitor : IWareVisitor
  {
    public double Visit(Alcohol ware)
    {
      return ware.Price * 3;
    }
    public double Visit(Tobacco ware)
    {
      return ware.Price * 1.1;
    }
    public double Visit(MilkProduct ware)
    {
      return ware.Price * 1;
    }
  }
}
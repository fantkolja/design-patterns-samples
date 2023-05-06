namespace DesignPatterns.Visitor
{
  interface IWareVisitor
  {
    public double Visit(Alcohol ware);
    public double Visit(Tobacco ware);
    public double Visit(MilkProduct ware);
  }
}
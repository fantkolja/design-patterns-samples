namespace DesignPatterns.Visitor
{
  class MilkProduct : Ware
  {
    public double Fat;
    public MilkProduct(string name, int price, double fat) : base(name, price)
    {
      this.Fat = fat;
    }
    public override string ToString()
    {
      return $"Milk product: {this.Name}";
    }
  }
}
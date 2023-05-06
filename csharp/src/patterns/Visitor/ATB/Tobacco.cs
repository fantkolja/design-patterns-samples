namespace DesignPatterns.Visitor
{
  class Tobacco : Ware
  {
    public double Nicotine;
    public Tobacco(string name, int price, double nicotine) : base(name, price)
    {
      this.Nicotine = nicotine;
    }
    public override string ToString()
    {
      return $"Tobacco: {this.Name}";
    }
  }
}
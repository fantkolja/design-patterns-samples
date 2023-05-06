namespace DesignPatterns.Visitor
{
  class Alcohol : Ware
  {
    public double Strength;
    public Alcohol(string name, int price, double strength) : base(name, price)
    {
      this.Strength = strength;
    }
    public override string ToString()
    {
      return $"Alcohol drink: {this.Name}";
    }
  }
}
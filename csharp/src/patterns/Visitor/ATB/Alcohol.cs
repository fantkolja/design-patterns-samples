namespace DesignPatterns.Visitor;
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












// namespace DesignPatterns.Visitor
// {
//   class Alcohol : Ware, IVisitableWare
//   {
//     public double Strength;
//     public Alcohol(string name, int price, double strength) : base(name, price)
//     {
//       this.Strength = strength;
//     }
//     public double Accept(IWareVisitor visitor)
//     {
//       return visitor.Visit(this);
//     }
//     public override string ToString()
//     {
//       return $"Alcohol drink: {this.Name}";
//     }
//   }
// }




// var visitor = new ExciseVisitor();

// List<Ware> wares= new List<Ware>
// {
//   new Alcohol("vodyara", 1, 40),
//   new Alcohol("whiskey", 1, 50),
//   new MilkProduct("Yahotyn", 1, 15)
// };

// wares.ForEach(ware => ware.Accept(visitor));
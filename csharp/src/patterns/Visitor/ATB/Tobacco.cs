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




























// namespace DesignPatterns.Visitor
// {
//   class Tobacco : Ware, IVisitableWare
//   {
//     public double Nicotine;
//     public Tobacco(string name, int price, double nicotine) : base(name, price)
//     {
//       this.Nicotine = nicotine;
//     }

//     public double Accept(IWareVisitor visitor)
//     {
//       return visitor.Visit(this);
//     }

//     public override string ToString()
//     {
//       return $"Tobacco: {this.Name}";
//     }
//   }
// }
namespace DesignPatterns.Bridge
{
  class MobTransport : Transport
  {
    public MobTransport(string name, int speed) : base(name)
    {
      this.Speed = speed;
    }

    public override void Move()
    {
      Console.WriteLine($"Moving on the {this.Name} with the speed {this.Speed}");
    }
  }
}










// namespace DesignPatterns.Bridge
// {
//   class MobTransport : Transport
//   {
//     public MobTransport(string name, int speed, ITransportationKind transportationKind) : base(name, transportationKind)
//     {
//       this.Speed = speed;
//     }

//     public override void Move()
//     {
//       _transportationKind.ChangePlace(this.Speed);
//     }
//   }
// }
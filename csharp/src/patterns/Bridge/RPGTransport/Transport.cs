namespace DesignPatterns.Bridge
{
  abstract class Transport
  {
    public int Speed { get; set; } = 1;
    public string Name { get; set; }

    public Transport(string name)
    {
      this.Name = name;
    }

    public abstract void Move();
  }
}












// namespace DesignPatterns.Bridge
// {
//   abstract class Transport
//   {
//     protected ITransportationKind _transportationKind;
//     public int Speed { get; set; } = 1;
//     public string Name { get; set; }

//     public Transport(string name, ITransportationKind transportationKind)
//     {
//       this._transportationKind = transportationKind;
//       this.Name = name;
//     }
//     public abstract void Move();
//   }
// }
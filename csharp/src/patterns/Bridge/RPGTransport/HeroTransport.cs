namespace DesignPatterns.Bridge
{
  abstract class HeroTransport
  {
    public int Capacity { get; set; } = 1;
    public int Speed { get; set; } = 1;
    public string Name { get; set; }

    public HeroTransport(string name, int speed, int capacity)
    : this(name, speed)
    {
      this.Capacity = capacity;
    }
    public HeroTransport(string name, int speed)
    : this(name)
    {
      this.Speed = speed;
    }
    public HeroTransport(string name)
    {
      this.Name = name;
    }

    public void Move()
    {
      Console.WriteLine($"Moving on the {this.Name} with the speed {this.Speed} carying {this.Capacity} heroes");
    }
  }
}




// Change request:
// - introduce flying transport subtypes, e.g. Land, Water, Air





























// namespace DesignPatterns.Bridge
// {
//   interface IWayOfTransportation
//   {
//     public void Move();
//   }

//   class LandTransportation : IWayOfTransportation
//   {
//     public void Move()
//     {
//       throw new NotImplementedException();
//     }
//   }

//   class AirTransportation : IWayOfTransportation
//   {
//     public void Move()
//     {
//       throw new NotImplementedException();
//     }
//   }

//   class WaterTransportation : IWayOfTransportation
//   {
//     public void Move()
//     {
//       throw new NotImplementedException();
//     }
//   }

//   abstract class HeroTransport
//   {
//     protected IWayOfTransportation _wayOfTransportation;
//     public int Capacity { get; set; } = 1;
//     public int Speed { get; set; } = 1;
//     public string Name { get; set; }
//     public HeroTransport(string name, IWayOfTransportation wayOfTransportation)
//     {
//       this.Name = name;
//       this._wayOfTransportation = wayOfTransportation;
//     }

//     public void Move()
//     {
//       this._wayOfTransportation.Move();
//     }
//   }
// }


// using DesignPatterns.Bridge;

// var horse = new Chair("Bucefal", new WaterTransportation());
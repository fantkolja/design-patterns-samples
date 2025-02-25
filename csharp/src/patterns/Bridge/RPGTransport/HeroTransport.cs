namespace DesignPatterns.Bridge
{
  class HeroTransport : Transport
  {
    public int Capacity { get; set; } = 1;

    public HeroTransport(string name, int speed, int capacity) : base(name)
    {
      this.Speed = speed;
      this.Capacity = capacity;
    }

    public override void Move()
    {
      Console.WriteLine($"Moving on the {this.Name} with the speed {this.Speed} carying {this.Capacity} heroes");
    }
  }
}



// using DesignPatterns.Bridge;

// var horse = new HeroTransport("Horse", 3, 2);
// var lizard = new MobTransport("lizard", 2);

// horse.Move();
// lizard.Move();




// Change request:
// - introduce flying transport subtypes, e.g. Land, Water, Air





































// namespace DesignPatterns.Bridge
// {
//   class HeroTransport : Transport
//   {
//     public int Capacity { get; set; } = 1;

//     public HeroTransport(string name, int speed, int capacity, ITransportationKind transportationKind) : base(name, transportationKind)
//     {
//       this.Speed = speed;
//       this.Capacity = capacity;
//     }

//     public override void Move()
//     {
//       _transportationKind.ChangePlace(this.Speed);
//     }
//   }
// }






// using DesignPatterns.Bridge;

// var airTransportation = new AirTransportation();
// var landTransportation = new LandTransportation();

// var horse = new HeroTransport("Horse", 3, 2, airTransportation);
// var lizard = new MobTransport("lizard", 2, landTransportation);

// horse.Move();
// lizard.Move();
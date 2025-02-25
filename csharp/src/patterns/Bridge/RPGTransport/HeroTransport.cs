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
  }

  class MobTransport : Transport
  {
    public MobTransport(string name, int speed) : base(name)
    {
      this.Speed = speed;
    }
  }

  class HeroTransport : Transport
  {
    public int Capacity { get; set; } = 1;

    public HeroTransport(string name, int speed, int capacity) : base(name)
    {
      this.Speed = speed;
      this.Capacity = capacity;
    }

    public void Move()
    {
      Console.WriteLine($"Moving on the {this.Name} with the speed {this.Speed} carying {this.Capacity} heroes");
    }
  }
}




// Change request:
// - introduce flying transport subtypes, e.g. Land, Water, Air





























// using DesignPatterns.Bridge;

// var horse = new Chair("Bucefal", new WaterTransportation());
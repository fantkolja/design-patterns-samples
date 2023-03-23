namespace DesignPatterns.Bridge
{
  class Horse : HeroTransport
  {
    public Horse(string name) : base(name)
    {
      this.Speed = 5;
      this.Capacity = 2;
    }
  }
}
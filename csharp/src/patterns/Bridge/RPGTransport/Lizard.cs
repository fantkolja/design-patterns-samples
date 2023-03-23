namespace DesignPatterns.Bridge
{
  class Lizard : HeroTransport
  {
    public Lizard(string name) : base(name)
    {
      this.Speed = 3;
    }
  }
}
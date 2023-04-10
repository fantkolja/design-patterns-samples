namespace DesignPatterns.Mediator
{
  class Runway
  {
    public ushort Capacity = 3;
    public List<IAircraft> PresentAircrafts = new List<IAircraft>();
  }
}
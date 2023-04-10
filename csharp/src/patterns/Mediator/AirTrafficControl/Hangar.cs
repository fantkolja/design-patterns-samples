namespace DesignPatterns.Mediator
{
  class  Hangar
  {
    public readonly Guid Id = Guid.NewGuid();
    public ushort Capacity = 3;
    public List<Aircraft> PresentAircrafts = new List<Aircraft>();
  }
}
namespace DesignPatterns.Bridge
{
  class LandTransportation : ITransportationKind
  {
    public void ChangePlace(int speed)
    {
      Console.WriteLine($"Moving by land with speed {speed}");
    }
  }
}
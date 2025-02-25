namespace DesignPatterns.Bridge
{
  class AirTransportation : ITransportationKind
  {
    public void ChangePlace(int speed)
    {
      Console.WriteLine($"Moving by air with speed {speed * 3}");
    }
  }
}
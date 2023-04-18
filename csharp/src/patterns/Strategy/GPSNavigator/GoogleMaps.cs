namespace DesignPatterns.Strategy
{
  class GoogleMaps
  {
    public TravelType Transport = TravelType.Walk;
    public int CalculateRouteDuration(int from, int to)
    {
      return from + to;
    }
  }
}
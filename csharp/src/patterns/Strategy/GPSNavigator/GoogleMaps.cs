namespace DesignPatterns.Strategy
{
  class GoogleMaps
  {
    public TravelType Transport = TravelType.Walk;
    public int CalculateRouteDuration(int from, int to)
    {
      int duration = 0;
      if (Transport == TravelType.Walk)
      {
        duration = from + to / 2;
      }
      else if(Transport == TravelType.Car)
      {
        duration = from + to / 20;
      }
      else if (Transport == TravelType.PublicTransport)
      {
        duration = from + to / 20;
      }
      return duration;
    }
  }
}









// namespace DesignPatterns.Strategy
// {
//   class GoogleMaps
//   {
//     public ITravelCalculator TravelCalculator = new WalkTravelCalculator();
//     public int CalculateRouteDuration(int from, int to)
//     {
//       return TravelCalculator.GetDuration(from, to);
//     }
//   }
// }

// using DesignPatterns.Strategy;

// var maps = new GoogleMaps();
// var carTravelCalculator = new CarTravelCalculator();

// maps.CalculateRouteDuration(1, 3);

// maps.TravelCalculator = carTravelCalculator;

// maps.CalculateRouteDuration(1, 3);
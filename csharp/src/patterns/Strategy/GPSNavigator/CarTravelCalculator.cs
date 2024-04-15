namespace DesignPatterns.Strategy
{
  class CarTravelCalculator : ITravelCalculator
  {
    public int GetDuration(int from, int to)
    {
      return from + to / 20;
    }
  }
}
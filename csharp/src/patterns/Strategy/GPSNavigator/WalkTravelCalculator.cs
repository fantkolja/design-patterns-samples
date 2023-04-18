namespace DesignPatterns.Strategy
{
  class WalkTravelCalculator : ITravelCalculator
  {
    public int GetDuration(int from, int to)
    {
      return from + to / 2;
    }
  }
}
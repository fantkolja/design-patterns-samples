namespace DesignPatterns.Strategy
{
  class CartravelCalculator : ITravelCalculator
  {
    public int GetDuration(int from, int to)
    {
      return from + to / 2;
    }
  }
}
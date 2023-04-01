namespace DesignPatterns.Flyweight
{
  static class FlyweightFactory
  {
    // stores flyweights by some calculated value of params
    private static Dictionary<int, Flyweight> _cache = new Dictionary<int, Flyweight>();
    public static Flyweight GetFlyweight(int prop1, int prop2)
    {
      int id = prop1 + prop2;
      Flyweight? flyweight = FlyweightFactory._cache.GetValueOrDefault(id);
      if (flyweight == null)
      {
        flyweight = new Flyweight(prop1, prop2);
        FlyweightFactory._cache[id] = flyweight;
      }
      return flyweight;
    }
  }
}
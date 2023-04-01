namespace DesignPatterns.Flyweight
{
  class Flyweight
  {
    private int _intrinsicProp1;
    private int _intrinsicProp2;
    public Flyweight(int prop1, int prop2)
    {
      Console.WriteLine($"Creating new flyweight with params: {prop1} and {prop2}");
      this._intrinsicProp1 = prop1;
      this._intrinsicProp2 = prop2;
    }
    public int DoSomething()
    {
      return this._intrinsicProp1 + this._intrinsicProp2;
    }
  }
}
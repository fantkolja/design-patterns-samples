namespace DesignPatterns.Flyweight
{
  class Flyweight
  {
    public int IntrinsicProp1;
    public int IntrinsicProp2;
    public Flyweight(int prop1, int prop2)
    {
      Console.WriteLine($"Creating new flyweight with params: {prop1} and {prop2}");
      this.IntrinsicProp1 = prop1;
      this.IntrinsicProp2 = prop2;
    }
  }
}
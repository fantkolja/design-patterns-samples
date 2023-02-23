namespace DesignPatterns.AbstractFactory
{
  class ConcreteProductB2 : IAbstarctProductB
  {
    public int Weight { get; private set; }

    public ConcreteProductB2(int weight)
    {
      this.Weight = weight;
    }
  }
}
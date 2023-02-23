namespace DesignPatterns.AbstractFactory
{
  class ConcreteProductB1 : IAbstarctProductB
  {
    public int Weight { get; private set; }

    public ConcreteProductB1(int weight)
    {
      this.Weight = weight;
    }
  }
}
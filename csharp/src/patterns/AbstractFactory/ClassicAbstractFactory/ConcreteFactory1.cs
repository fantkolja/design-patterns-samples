namespace DesignPatterns.AbstractFactory
{
  class ConcreteFactory1 : IAbstractFactory
  {
    public IAbstarctProductA CreateConcreteProductA()
    {
      return new ConcreteProductA1("A");
    }

    public IAbstarctProductB CreateConcreteProductB()
    {
      return new ConcreteProductB1(1);
    }
  }
}
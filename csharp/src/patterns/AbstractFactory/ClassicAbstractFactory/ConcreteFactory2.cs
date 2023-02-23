namespace DesignPatterns.AbstractFactory
{
  class ConcreteFactory2 : IAbstractFactory
  {
    public IAbstarctProductA CreateConcreteProductA()
    {
      return new ConcreteProductA2("A");
    }

    public IAbstarctProductB CreateConcreteProductB()
    {
      return new ConcreteProductB2(2);
    }
  }
}
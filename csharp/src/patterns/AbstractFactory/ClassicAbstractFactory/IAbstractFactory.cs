namespace DesignPatterns.AbstractFactory
{
  interface IAbstractFactory
  {
    public IAbstarctProductA CreateConcreteProductA();
    public IAbstarctProductB CreateConcreteProductB();
  }
}
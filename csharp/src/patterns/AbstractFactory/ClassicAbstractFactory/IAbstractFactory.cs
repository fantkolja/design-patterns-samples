namespace DesignPatterns.AbstractFactory
{
  interface IAbstractFactory
  {
    public IAbstarctProductA CreateConcreteProductA();
    public IAbstarctProductB CreateConcreteProductB();
  }
}





















// using DesignPatterns.AbstractFactory;


// static void CreateProducts(IAbstractFactory factory)
// {
//   IAbstarctProductA productA = factory.CreateConcreteProductA();
//   IAbstarctProductB productB = factory.CreateConcreteProductB();
// }


// CreateProducts(new ConcreteFactory1());
// CreateProducts(new ConcreteFactory2());
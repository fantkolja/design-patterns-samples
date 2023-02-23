using DesignPatterns.AbstractFactory;


static void CreateProducts(IAbstractFactory factory)
{
  IAbstarctProductA productA = factory.CreateConcreteProductA();
  IAbstarctProductB productB = factory.CreateConcreteProductB();
}


CreateProducts(new ConcreteFactory1());
CreateProducts(new ConcreteFactory2());

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
namespace DesignPatterns.AbstractFactory
{
  class ConcreteProductA1 : IAbstarctProductA
  {
    public string Name { get; private set; }

    public ConcreteProductA1(string name)
    {
      this.Name = name;
    }
  }
}
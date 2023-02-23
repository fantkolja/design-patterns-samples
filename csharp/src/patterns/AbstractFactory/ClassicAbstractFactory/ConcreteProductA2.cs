namespace DesignPatterns.AbstractFactory
{
  class ConcreteProductA2 : IAbstarctProductA
  {
    public string Name { get; private set; }

    public ConcreteProductA2(string name)
    {
      this.Name = name;
    }
  }
}
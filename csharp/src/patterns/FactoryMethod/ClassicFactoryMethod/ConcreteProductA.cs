namespace DesignPatterns.FactoryMethod
{
  class ConcreteProductA : IClassicProduct
  {
    private string _name;

    public ConcreteProductA(string name)
    {
      this._name = name;
    }

    public string GetName()
    {
      return $"This is Product A with the name {this._name}";
    }
  }
}
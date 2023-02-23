namespace DesignPatterns.FactoryMethod
{
  class ConcreteProductB : IClassicProduct
  {
    private string _model;

    public ConcreteProductB(string model)
    {
      this._model = model;
    }

    public string GetName()
    {
      return $"This is model {this._model}";
    }
  }
}
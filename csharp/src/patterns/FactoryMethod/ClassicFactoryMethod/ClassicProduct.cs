namespace DesignPatterns.FactoryMethod
{
  public interface ClassicProduct
  {
    string GetName();
  }

  class ConcreteProductA : ClassicProduct
  {
    private string _name;

    public ConcreteProductA(string name)
    {
      this._name = name;
    }

    public string GetName()
    {
      return this._name;
    }
  }

    class ConcreteProductB : ClassicProduct
  {
    private string _model;
    private int _buildYear;

    public ConcreteProductB(string model, int year)
    {
      this._model = model;
      this._buildYear = year;
    }

    public string GetName()
    {
      return this._model;
    }
  }
}
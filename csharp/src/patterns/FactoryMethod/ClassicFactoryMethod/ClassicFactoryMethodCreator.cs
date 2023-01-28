namespace DesignPatterns.FactoryMethod
{
  static class ClassicFactoryMethodCreator
  {
    public static ClassicProduct CreateProduct(string name, int? year)
    {
      ClassicProduct result;
      if (year.HasValue)
      {
        result = new ConcreteProductB(name, (int)year);
      }
      else
      {
        result = new ConcreteProductA(name);
      }
      return result;
    }
  }
}
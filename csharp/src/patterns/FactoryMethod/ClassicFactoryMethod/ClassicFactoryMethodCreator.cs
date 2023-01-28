namespace DesignPatterns.FactoryMethod
{
  abstract class ClassicFactoryMethodCreator
  {
    abstract public ClassicProduct CreateProduct(string name, int? year);
  }

  class ClassicFactoryMethodCreatorA : ClassicFactoryMethodCreator
  {
    public override ClassicProduct CreateProduct(string name, int? year)
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

  class ClassicFactoryMethodCreatorB : ClassicFactoryMethodCreator
  {
    public override ClassicProduct CreateProduct(string name, int? year)
    {
      int derivedYear = year.HasValue ? (int)year : DateTime.Now.Year;
      return new ConcreteProductB(name, derivedYear);
    }
  }
}
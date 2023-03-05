namespace DesignPatterns.Decorator
{
  abstract class BaseDecorator : IWrappee
  {
    protected IWrappee _wrappee;

    public BaseDecorator(IWrappee wrappee)
    {
      this._wrappee = wrappee;
    }

    abstract public int Operation();
  }
}













// using DesignPatterns.Decorator;

// IWrappee component = new ConcreteWrappee();

// if (component.Operation() > 0)
// {
//   component = new MultiplyDecorator(component, 100);
// }

// if (component.Operation() > 10)
// {
//   component = new SqrtDecorator(component);
// }

// Console.WriteLine(component.Operation());
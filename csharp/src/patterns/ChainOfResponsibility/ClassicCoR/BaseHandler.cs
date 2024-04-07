namespace DesignPatterns.ChainOfResponsibility
{
  abstract class BaseHandler : IHandler
  {
    private IHandler? _next;

    public IHandler SetNextHandler(IHandler next)
    {
      this._next = next;

      // similiar to fluent interface
      return next;
    }

    public virtual void Handle(int arg)
    {
      if (this._next != null)
      {
        this._next.Handle(arg);
      }
      else 
      {
        Console.WriteLine("Default Handler Implementation");
      }
    }
  }
}

// using DesignPatterns.ChainOfResponsibility;


// var handler1 = new ConcreteHandler1();
// var handler2 = new ConcreteHandler2();

// handler1.SetNextHandler(handler2);

// handler2.Handle(4);
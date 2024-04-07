namespace DesignPatterns.ChainOfResponsibility
{
  abstract class BaseHandler
  {
    private BaseHandler? _next;

    public BaseHandler SetNextHandler(BaseHandler next)
    {
      this._next = next;

      // similiar to fluent interface
      // or to a Singly Linked List
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


// BaseHandler handler1 = new ConcreteHandler1();
// BaseHandler handler2 = new ConcreteHandler2();

// handler1.SetNextHandler(handler2);

// handler1.Handle(7);
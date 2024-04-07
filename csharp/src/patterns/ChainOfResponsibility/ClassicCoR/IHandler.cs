namespace DesignPatterns.ChainOfResponsibility
{
  interface IHandler
  {
    IHandler SetNextHandler(IHandler handler);
    public void Handle(int arg);
  }
}

















// using DesignPatterns.ChainOfResponsibility;

// var handler1 = new ConcreteHandler1();
// var handler2 = new ConcreteHandler2();

// handler1.SetNextHandler(handler2);

// handler1.Handle(8);
// handler1.Handle(2);
// handler1.Handle(5);
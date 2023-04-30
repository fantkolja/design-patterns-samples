namespace DesignPatterns.ChainOfResponsibility
{
  class ConcreteHandler1 : BaseHandler
  {
    public override void Handle(int arg)
    {
      if (arg > 5)
      {
        Console.WriteLine("Arg is greater than 5");
      }
      else
      {
        base.Handle(arg);
      }
    }
  }
}
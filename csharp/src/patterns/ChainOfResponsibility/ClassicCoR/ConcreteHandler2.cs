namespace DesignPatterns.ChainOfResponsibility
{
  class ConcreteHandler2 : BaseHandler
  {
    public override void Handle(int arg)
    {
      if (arg < 5)
      {
        Console.WriteLine("Arg is less than 5");
      }
      else
      {
        base.Handle(arg);
      }
    }
  }
}
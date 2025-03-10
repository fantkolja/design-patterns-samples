namespace DesignPatterns.Decorator
{
  class SqrtDecorator : BaseDecorator
  {
    public SqrtDecorator(IWrappee wrappee) : base(wrappee) {}

    public override int Operation()
    {
      Console.WriteLine("[SqrtDecorator] Calculation");
      return (int)Math.Sqrt(base.Operation());
    }
  }
}
namespace DesignPatterns.Decorator
{
  class MultiplyDecorator : BaseDecorator
  {
    private int _factor;
    public MultiplyDecorator(IWrappee wrappee, int factor) : base(wrappee)
    {
      this._factor = factor;
    }

    public override int Operation()
    {
      Console.WriteLine("[MultiplyDecorator] Calculation");
      return base.Operation() * this._factor;
    }
  }
}
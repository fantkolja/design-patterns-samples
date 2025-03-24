namespace DesignPatterns.Mediator
{
  class Component1 : BaseComponent
  {
    public Component1(IMediator mediator, string? name) : base(mediator, name) {}

    public void MethodA()
    {
      Console.WriteLine("Component 1 does A.");
    }

    public void MethodB()
    {
      Console.WriteLine("Component 1 does B.");
      this._mediator.OnActionB(this);
    }
  }
}
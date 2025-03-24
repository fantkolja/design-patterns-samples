namespace DesignPatterns.Mediator
{
  class Component2 : BaseComponent
  {
    public Component2(string? name) : base(name) {}

    public void MethodC()
    {
      Console.WriteLine("Component 2 does C.");
      this._mediator?.OnActionA("A");
    }

    public void MethodD()
    {
      Console.WriteLine("Component 2 does D.");
    }
  }
}
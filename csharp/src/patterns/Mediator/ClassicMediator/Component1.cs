namespace DesignPatterns.Mediator
{
  class Component1 : BaseComponent
  {
    public Component1(string? name) : base(name) {}

    public void MethodA()
    {
      Console.WriteLine("Component 1 does A.");
    }

    public void MethodB()
    {
      Console.WriteLine("Component 1 does B.");
      this._mediator?.OnActionB(this);
    }
  }
}
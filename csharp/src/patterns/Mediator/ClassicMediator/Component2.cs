namespace DesignPatterns.Mediator
{
  class Component2 : BaseComponent
  {
    public void MethodC()
    {
      Console.WriteLine("Component 2 does C.");
      this._notifyMediator("Event C");
    }

    public void MethodD()
    {
      Console.WriteLine("Component 2 does D.");
      this._notifyMediator("Event D");
    }
  }
}
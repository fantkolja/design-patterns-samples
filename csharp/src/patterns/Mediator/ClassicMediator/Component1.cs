namespace DesignPatterns.Mediator
{
  class Component1 : BaseComponent
  {
    public void MethodA()
    {
      Console.WriteLine("Component 1 does A.");
      this._notifyMediator("Event A");
    }

    public void MethodB()
    {
      Console.WriteLine("Component 1 does B.");
      this._notifyMediator("Event B");
    }
  }
}
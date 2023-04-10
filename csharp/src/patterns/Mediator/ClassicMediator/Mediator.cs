namespace DesignPatterns.Mediator
{
  // Business logic:
  // - when "Event A" occurs, thrigger MethodC
  // - when "Event D" occurs, thrigger MethodB and MethodC
  class Mediator
  {
    private Component1 _component1;

    private Component2 _component2;

    public Mediator(Component1 component1, Component2 component2)
    {
      this._component1 = component1;
      this._component1.Mediator = this;
      this._component2 = component2;
      this._component2.Mediator = this;
    } 

    public void Notify(string ev)
    {
      if (ev == "Event A")
      {
          Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
          this._component2.MethodC();
      }
      if (ev == "Event D")
      {
          Console.WriteLine("Mediator reacts on D and triggers following operations:");
          this._component1.MethodB();
          this._component2.MethodC();
      }
    }
  }
}
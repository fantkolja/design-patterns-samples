namespace DesignPatterns.Mediator
{
  // 1:A => 2:C; 2:D => 1:B + 2:C
  class Mediator : IMediator
  {
    private Component1 _component1;

    private Component2 _component2;

    public Mediator(Component1 component1, Component2 component2)
    {
      this._component1 = component1;
      this._component2 = component2;
    }

    public void OnActionA(string ev)
    {
      throw new NotImplementedException();
    }

    public void OnActionB(BaseComponent component)
    {
      throw new NotImplementedException();
    }
  }
}




// using DesignPatterns.Mediator;

// Component1 component1 = new Component1();
// Component2 component2 = new Component2();
// new Mediator(component1, component2);

// component1.MethodA();

// component2.MethodD();







// with "event-bus-like" implementation

// namespace DesignPatterns.Mediator
// {
//   class Mediator
//   {
//     private Component1 _component1;

//     private Component2 _component2;

//     public Mediator(Component1 component1, Component2 component2)
//     {
//       this._component1 = component1;
//       this._component1.Mediator = this;
//       this._component2 = component2;
//       this._component2.Mediator = this;
//     } 

//     public void Notify(string ev)
//     {
//       if (ev == "Event A")
//       {
//           Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
//           this._component2.MethodC();
//       }
//       if (ev == "Event D")
//       {
//           Console.WriteLine("Mediator reacts on D and triggers following operations:");
//           this._component1.MethodB();
//           this._component2.MethodC();
//       }
//     }
//   }
// }
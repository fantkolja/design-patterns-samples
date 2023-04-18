namespace DesignPatterns.Observer
{
  class SubmitButton
  {
    public void Click()
    {
      Console.WriteLine("Submit");
    }
  }
}

























// Version 1: with Observer pattern
// namespace DesignPatterns.Observer
// {
//   interface Subscriber
//   {
//     public void Process();
//   }

//   class Publisher
//   {

//     private List<Subscriber> _subscribers = new List<Subscriber>();

//     public void Subscribe(Subscriber subscriber)
//     {
//       this._subscribers.Add(subscriber);
//     }
//     public void Unsubscribe(Subscriber subscriber)
//     {
//       this._subscribers.Remove(subscriber);
//     }
//     protected void _notify()
//     {
//       this._subscribers.ForEach(sub => sub.Process());
//     }
//   }

//   class SubmitButton : Publisher
//   {
//     public void Click()
//     {
//       Console.WriteLine("Submit");
//       this._notify();
//     }
//   }
// }


// Version 2: with lambdas
// namespace DesignPatterns.Observer
// {
//   class Publisher
//   {

//     private List<Action> _subscribers = new List<Action>();

//     public void Subscribe(Action action)
//     {
//       this._subscribers.Add(action);
//     }
//     public void Unsubscribe(Action action)
//     {
//       this._subscribers.Remove(action);
//     }
//     protected void _notify()
//     {
//       this._subscribers.ForEach(sub => sub());
//     }
//   }

//   class SubmitButton : Publisher
//   {
//     public void Click()
//     {
//       Console.WriteLine("Submit");
//       this._notify();
//     }
//   }
// }



// Version 3: with built-in events 
// namespace DesignPatterns.Observer
// {
//   class SubmitButton
//   {
//     public void Click()
//     {
//       this.Submitted.Invoke(this, EventArgs.Empty);
//     }

//     public event EventHandler<EventArgs> Submitted;

//     public SubmitButton()
//     {
//       this.Submitted += (object? sender, EventArgs e) => Console.WriteLine("Submit");
//     }
//   }
// }
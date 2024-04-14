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

























// Versions 1, 2: with Observer pattern
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





// Version 3: with lambdas
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
//       this._subscribers.ForEach(subscriber => subscriber());
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



// Version 4: with built-in events 
// namespace DesignPatterns.Observer
// {
//   class SubmitButton
//   {
//     public void Click()
//     {
//       Console.WriteLine("Submit");
//       this.Submitted?.Invoke(this, EventArgs.Empty);
//     }

//     public event EventHandler<EventArgs>? Submitted;
//   }
// }
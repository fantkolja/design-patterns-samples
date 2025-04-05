namespace DesignPatterns.Observer
{
  class SubmitButton
  {
    public void Click() {
      // should trigger ValidateInputs() on the LoginForm && change Text on Tooltip
    }
  }
}





// Versions 1: classic
// namespace DesignPatterns.Observer
// {

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
//   class ButtonSubject
//   {
//     private List<ISubscriber> _subscribers = new List<ISubscriber>();
//     public void AddSubscriber(ISubscriber subscriber)
//     {
//       _subscribers.Add(subscriber);
//     }
//     public void RemoveSubscriber(ISubscriber subscriber)
//     {
//       _subscribers.Remove(subscriber);
//     }
//     protected void _notifySubscribers()
//     {
//       _subscribers.ForEach(subscriber => subscriber.OnSubmit());
//     }
//   }

//   class SubmitButton : ButtonSubject
//   {
//     public void Click() {
//       _notifySubscribers();
//     }
//   }
// }


// using DesignPatterns.Observer;

// var form = new LoginForm();
// var tooltip = new Tooltip();
// var button = new SubmitButton();

// button.AddSubscriber(() => form.ValidateInputs());

// button.Click();














// Version 3: with built-in events
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

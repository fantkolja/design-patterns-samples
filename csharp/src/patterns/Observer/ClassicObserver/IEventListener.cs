namespace DesignPatterns.Observer
{
  interface IEventListener
  {
    public void Update(int arg);
  }
}


// using DesignPatterns.Observer;

// var subject = new Subject();
// var counter = new CounterObserver();
// var cache = new CacheObserver();

// subject.InvokeEvent(0);

// subject.Subscribe(counter);

// subject.InvokeEvent(1);
// subject.InvokeEvent(2);

// subject.Subscribe(cache);

// subject.InvokeEvent(3);
// subject.InvokeEvent(4);

// subject.Unsubscribe(counter);

// subject.InvokeEvent(5);

// counter.DisplayInfo();
// cache.DisplayInfo();

// use generics for ARGS
// use events
using DesignPatterns.Observer;

var subject = new Subject();
var counter = new CounterObserver();
var cache = new CacheObserver();

subject.InvokeEvent(0);

subject.Subscribe(counter);

subject.InvokeEvent(1);
subject.InvokeEvent(2);

subject.Subscribe(cache);

subject.InvokeEvent(3);
subject.InvokeEvent(4);

subject.Unsubscribe(counter);

subject.InvokeEvent(5);

counter.DisplayInfo();
cache.DisplayInfo();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
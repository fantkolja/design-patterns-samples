using DesignPatterns.CoR;

var handler1 = new ConcreteHandler1();
var handler2 = new ConcreteHandler2();

handler1.SetNextHandler(handler2);

handler1.Handle(8);
handler1.Handle(2);
handler1.Handle(5);

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
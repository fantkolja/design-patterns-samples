using DesignPatterns.Flyweight;

var ctx1 = new Context("a", "b", 1, 2);
var ctx2 = new Context("c", "d", 1, 2);
var ctx3 = new Context("e", "f", 1, 2);
var ctx4 = new Context("g", "h", 3, 4);
var ctx5 = new Context("i", "j", 3, 4);

ctx1.DoSomething();
ctx2.DoSomething();
ctx3.DoSomething();
ctx4.DoSomething();
ctx5.DoSomething();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
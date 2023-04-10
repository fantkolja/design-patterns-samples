using DesignPatterns.Mediator;

Component1 component1 = new Component1();
Component2 component2 = new Component2();
new Mediator(component1, component2);

component1.MethodA();

component2.MethodD();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
using DesignPatterns.Mediator;

Component1 component1 = new Component1("Component 1");
Component2 component2 = new Component2("Component 2");

new Mediator(component1, component2);

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
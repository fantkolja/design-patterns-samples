using DesignPatterns.Decorator;

Coffee order = new Doubled(new WithMilk(new Espresso()));

Coffee order2 = new WithSugar(new Americano(), 2);

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
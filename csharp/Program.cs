using DesignPatterns.Builder;

var car = new CarBuilder()
  .WithEngine("tdi 3.0")
  .HavingWheelSize(3)
  .Build();


Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
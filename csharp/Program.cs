using DesignPatterns.Builder;

var builder = new CarBuilder();
builder
    .WithEngine("1.6L")
    .WithTransmission("ZF");


Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
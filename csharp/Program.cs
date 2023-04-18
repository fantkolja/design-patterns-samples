using DesignPatterns.Observer;

var game = new Game();
game.Start();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
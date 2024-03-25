using DesignPatterns.Adapter;

var smallShape = new Cylinder(5);
var bigShape = new Cylinder(8);
var hole = new RoundHole(6);

Console.WriteLine(hole.Fits(smallShape));
Console.WriteLine(hole.Fits(bigShape));

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
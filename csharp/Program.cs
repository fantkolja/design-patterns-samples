using DesignPatterns.Flyweight;

var parser = new DocumentParser();

var letter = parser.GetLetterAt(49, 1);

if (letter is Letter)
{
  Console.WriteLine($"DisplayName: {letter.DisplayName}; CharCode: {letter.CharCode}");
}
else 
{
  Console.WriteLine("There is no such letter");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
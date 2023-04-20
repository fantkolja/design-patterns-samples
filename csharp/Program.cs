using DesignPatterns.Iterator;
using DesignPatterns.Flyweight;

Console.WriteLine("===Before dictionary creation===");
MemoryMonitor.CheckCurrentProcess();

var dictionary = TextParser.GetWordList("./tmp/little_women.txt");

Console.WriteLine("");
Console.WriteLine("*******************");
Console.WriteLine($"Dictionary size: {dictionary.Count}");
Console.WriteLine("*******************");
Console.WriteLine("");

Console.WriteLine("===After dictionary creation===");
MemoryMonitor.CheckCurrentProcess();

await DictionaryWriter.WriteToFileAsync(dictionary, "./tmp/little_women.dict.txt");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
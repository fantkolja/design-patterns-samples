using DesignPatterns.Iterator;

Trie dictionary = TextParser.GetWordTrie("./tmp/little_women.txt");

Console.WriteLine("");
Console.WriteLine("*******************");
// Console.WriteLine($"Dictionary size: {dictionary.Count}");
var checks = new List<string>(){ "absurd", "absurdities", "absurditiessdfcfasdc" };
// should be true, true, false
checks.ForEach((word) => Console.WriteLine(dictionary.Contains(word)));
Console.WriteLine("*******************");
Console.WriteLine(dictionary.Links.Count);
Console.WriteLine("*******************");
Console.WriteLine("");

// await DictionaryWriter.WriteToFileAsync(dictionary.Values.ToList(), "./tmp/little_women.dict.txt");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
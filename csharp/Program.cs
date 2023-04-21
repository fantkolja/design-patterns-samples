using DesignPatterns.Iterator;

SortedDictionary<string, string> wordDictionary = TextParser.GetWordDictionary("./tmp/little_women.txt");

Console.WriteLine("");
Console.WriteLine("*******************");
Console.WriteLine("======Checking Words=========");
new List<string>(){ "absurd", "absurdities", "absurditiessdfcfasdc" }
// should be true, true, false
  .ForEach((word) => Console.WriteLine(wordDictionary.GetValueOrDefault(word) != null));
Console.WriteLine($"Dictionary size: {wordDictionary.Count}");
Console.WriteLine("*******************");
Console.WriteLine("");

await DictionaryWriter.WriteToFileAsync(wordDictionary.Values, "./tmp/little_women.dict.txt");

Trie wordTrie = TextParser.GetWordTrie("./tmp/little_women.txt");

Console.WriteLine("");
Console.WriteLine("*******************");
Console.WriteLine("======Checking Words=========");
// Console.WriteLine($"Dictionary size: {dictionary.Count}");
new List<string>(){ "absurd", "absurdities", "absurditiessdfcfasdc" }
// should be true, true, false
  .ForEach((word) => Console.WriteLine(wordTrie.Contains(word)));
Console.WriteLine("*******************");
Console.WriteLine(wordTrie.Links.Count);
Console.WriteLine("*******************");
Console.WriteLine("");

// await DictionaryWriter.WriteToFileAsync(wordTrie.Values.ToList(), "./tmp/little_women.dict.txt");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
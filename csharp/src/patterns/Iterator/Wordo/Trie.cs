namespace DesignPatterns.Iterator;

public class TrieNode
{
  public bool IsWord { get; set; }
  public SortedDictionary<char, TrieNode> Children { get; } = new();
}

public class Trie
{
  private readonly TrieNode _root = new();

  public void Insert(string word)
  {
    var node = _root;
    foreach (var ch in word)
    {
      if (!node.Children.ContainsKey(ch))
      {
        node.Children[ch] = new TrieNode();
      }
      node = node.Children[ch];
    }
    node.IsWord = true;
  }

  public bool Contains(string word)
  {
    var node = _root;
    foreach (var ch in word)
    {
      if (!node.Children.TryGetValue(ch, out node))
        return false;
    }
    return node.IsWord;
  }
}






// using DesignPatterns.Iterator;

// SortedDictionary<string, string> wordDictionary = TextParser.GetWordDictionary("./tmp/little_women.txt");
// // should be true, true, false
// var controlWords = new List<string>(){ "absurd", "absurdities", "absurditiessdfcfasdc" };

// Console.WriteLine("");
// Console.WriteLine("*******************");
// Console.WriteLine("======Checking Words=========");

// controlWords.ForEach((word) => Console.WriteLine(wordDictionary.GetValueOrDefault(word) != null));

// Console.WriteLine($"Dictionary size: {wordDictionary.Count}");
// Console.WriteLine("*******************");
// Console.WriteLine("");

// await DictionaryWriter.WriteToFileAsync(wordDictionary.Values, "./tmp/little_women.dict.txt");

// Trie wordTrie = TextParser.GetWordTrie("./tmp/little_women.txt");

// Console.WriteLine("");
// Console.WriteLine("*******************");
// Console.WriteLine("======Checking Words=========");

// controlWords.ForEach((word) => Console.WriteLine(wordTrie.Contains(word)));

// Console.WriteLine("*******************");
// // Console.WriteLine($"WordTrie size: {wordTrie.Count}");
// Console.WriteLine("*******************");
// Console.WriteLine("");

// // await DictionaryWriter.WriteToFileAsync(wordTrie.ToWordList(), "./tmp/little_women.trie.txt");





// public class Trie
// {
//   private readonly TrieNode _root = new();

//   public void Insert(string word)
//   {
//     var node = _root;
//     foreach (var ch in word)
//     {
//       if (!node.Children.ContainsKey(ch))
//       {
//         node.Children[ch] = new TrieNode();
//       }
//       node = node.Children[ch];
//     }
//     node.IsWord = true;
//   }

//   public bool Contains(string word)
//   {
//     var node = _root;
//     foreach (var ch in word)
//     {
//       if (!node.Children.TryGetValue(ch, out node))
//         return false;
//     }
//     return node.IsWord;
//   }

//   public int Count
//   {
//     get
//     {
//       int counter = 0;
//       foreach (var word in GetWords())
//       {
//         counter++;
//       }
//       return counter;
//     }
//   }

//   public IEnumerable<string> GetWords()
//   {
//     return Traverse(_root, "");
//   }

//   private IEnumerable<string> Traverse(TrieNode node, string prefix)
//   {
//     if (node.IsWord)
//       yield return prefix;

//     foreach (var key in node.Children.Keys)
//     {
//       foreach (var word in Traverse(node.Children[key], prefix + key))
//       {
//         yield return word;
//       }
//     }
//   }
// }
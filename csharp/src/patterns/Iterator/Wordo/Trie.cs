namespace DesignPatterns.Iterator
{
  class Trie
  {
    private const char ROOT_TRIE_CHAR = '\n';
    private const char WORD_END_CHAR = '\0';
    public char Char { get; set; }
    public int Count
    {
      get
      {
        return this.ToWordList().Count;
      }
    }
    private SortedDictionary<char, Trie> _links = new SortedDictionary<char, Trie>();
    public Trie(char content)
    {
      this.Char = content;
    }
    public bool Contains(string word)
    {
      // handle end of the word
      if (word.Length == 0)
      {
        return this._links.GetValueOrDefault(WORD_END_CHAR) != null;
      }
      else
      {
        char firstChar = word[0];
        string rest = word.Substring(1);
        Trie? nextTrie = this._links.GetValueOrDefault(firstChar);
        return nextTrie != null && nextTrie.Contains(rest);
      }
    }
    public Trie? GetTrieByChar(char key)
    {
      return this._links.GetValueOrDefault(key);
    }
    public void Add(string word)
    {
      // handle end of the word
      if (word.Length == 0)
      {
        char firstChar = WORD_END_CHAR;
        this._links.Add(firstChar, new Trie(WORD_END_CHAR));
      }
      else
      {
        char firstChar = word[0];
        string rest = word.Substring(1);
        Trie? existingTrie = this._links.GetValueOrDefault(firstChar);
        if (existingTrie == null)
        {
          Trie newTrie = new Trie(firstChar);
          this._links.Add(firstChar, newTrie);
          newTrie.Add(rest);
        }
        else
        {
          existingTrie.Add(rest);
        }
      }
    }

    public List<string> ToWordList()
    {
      throw new NotImplementedException();
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




































    // public TrieIterator GetTrieIterator()
    // {
    //   return new TrieIterator(this);
    // }
    // public List<string> ToWordList()
    // {
    //   var trieIterator = this.GetTrieIterator();
    //   var trieList = new List<string>();
    //   while(!trieIterator.IsDone())
    //   {
    //     string? next = trieIterator.Next();
    //     if (next != null)
    //     {
    //       trieList.Add(next);
    //     }
    //   }
    //   return trieList;
    // }
    // public class TrieIterator
    // {
    //   // trie array for each char in reversed order
    //   private List<Trie> _currentWordTries;
    //   private bool _isFirstTimeRun = true;
    //   public TrieIterator(Trie trie)
    //   {
    //     this._currentWordTries = new List<Trie>(){ trie };
    //   }
    //   public bool IsDone()
    //   {
    //     return !this._isFirstTimeRun && this._currentWordTries[0].Char == ROOT_TRIE_CHAR;
    //   }
    //   public void Reset()
    //   {
    //     this._isFirstTimeRun = true;
    //     this._currentWordTries = new List<Trie>(){ this._currentWordTries.Last() };
    //   }
    //   private bool _checkLoopEnd()
    //   {
    //     bool isDone = this.IsDone();
    //     if (!isDone)
    //     {
    //       this._isFirstTimeRun = false;
    //     }
    //     return isDone;
    //   }

    //   private string _parseWordFromCurrentWordTries()
    //   {
    //     return this._currentWordTries.Aggregate("", (string word, Trie nextTrie) => {
    //       if (nextTrie.Char != WORD_END_CHAR && nextTrie.Char != ROOT_TRIE_CHAR)
    //       {
    //         word = String.Concat(nextTrie.Char, word);
    //       }
    //       return word;
    //     });
    //   }
    //   private Trie? _getNextWordInitialTrie()
    //   {
    //     return this._currentWordTries[0]._links.Values.ElementAtOrDefault(this._currentWordTries[0].Char == ROOT_TRIE_CHAR ? 0 : 1);
    //   }
    //   private Trie? _traverseTrieDown(Trie trie)
    //   {
    //     var nextTrie = trie;
    //     this._currentWordTries = this._currentWordTries.Prepend(nextTrie).ToList();
    //     while (nextTrie._links.ToArray()[0].Value.Char != WORD_END_CHAR)
    //     {
    //       nextTrie = nextTrie._links.ToArray()[0].Value;
    //       this._currentWordTries = this._currentWordTries.Prepend(nextTrie).ToList();
    //     }
    //     return nextTrie;
    //   }
    //   private Trie? _traverseTrieUp(Trie? trie)
    //   {
    //     var nextTrie = trie;
    //     while(nextTrie == null && this._currentWordTries.Count > 1)
    //     {
    //       Trie lastLetterTrie = this._currentWordTries.ElementAt(0);
    //       this._currentWordTries.RemoveAt(0);
    //       int index = this._currentWordTries[0]._links.Values.ToList().IndexOf(lastLetterTrie);
    //       nextTrie = this._currentWordTries[0]._links.Values.ElementAtOrDefault(index + 1);
    //     }
    //     return nextTrie;
    //   }
    //   public string? Next()
    //   {
    //     // check end of the iteration loop
    //     if (this._checkLoopEnd())
    //     {
    //       return null;
    //     }
    //     Trie? nextTrie = this._getNextWordInitialTrie();
    //     // lookup the word with extra chars
    //     if (nextTrie != null)
    //     {
    //       nextTrie = this._traverseTrieDown(nextTrie);
    //     }
    //     else
    //     // lookup the word with less chars 
    //     {
    //       nextTrie = this._traverseTrieUp(nextTrie);
    //       if (nextTrie != null)
    //       {
    //         nextTrie = this._traverseTrieDown(nextTrie);
    //       }
    //     }
    //     string nextWord = this._parseWordFromCurrentWordTries();
    //     return nextWord.Length  == 0 ? null : nextWord;
    //   }
    // }
  }
}
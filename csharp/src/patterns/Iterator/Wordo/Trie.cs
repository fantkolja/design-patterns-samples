namespace DesignPatterns.Iterator
{
  class Trie
  {
    // root node \0
    // end of word \n
    public char Char { get; set; }
    public int Count
    {
      get
      {
        throw new NotImplementedException();
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
        return this._links.GetValueOrDefault('\n') != null;
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
        char firstChar = '\n';
        this._links.TryAdd(firstChar, new Trie('\n'));
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






















    class TrieIterator
    {
      private string _currentWord;
      private Trie _rootTrie;
      public TrieIterator(Trie trie)
      {
        this._rootTrie = trie;
      }
      public string? Next()
      {
        char[] currentWordChars = this._currentWord.ToCharArray();
        // get last node
        Trie currentTrie = currentWordChars.Aggregate(this._rootTrie, (trie, nextChar) => trie._links.Get);

        List<Trie> linkedTries = new List<Trie>();
        while (trie.Get)
        {

        }
        this._currentWord = linkedTries.Aggregate("", (word, trie) => $"{word}{trie.Char}");
      }
    }
  }
}
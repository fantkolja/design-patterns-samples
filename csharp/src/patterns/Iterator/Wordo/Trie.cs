namespace DesignPatterns.Iterator
{
  class Trie
  {
    // root node \0
    // end of word \n
    public char Char { get; set; }
    public SortedDictionary<char, Trie> Links = new SortedDictionary<char, Trie>();
    public Trie(char content)
    {
      this.Char = content;
    }
    public bool Contains(string word)
    {
      // handle end of the word
      if (word.Length == 0)
      {
        return this.Links.GetValueOrDefault('\n') != null;
      }
      else
      {
        char firstChar = word[0];
        string rest = word.Substring(1);
        Trie? nextTrie = this.Links.GetValueOrDefault(firstChar);
        return nextTrie != null && nextTrie.Contains(rest);
      }
    }
    public void Add(string word)
    {
      if (word.Length == 0)
      {
        char firstChar = '\n';
        this.Links.TryAdd(firstChar, new Trie('\n'));
      }
      else
      {
        char firstChar = word[0];
        string rest = word.Substring(1);
        Trie? existingTrie = this.Links.GetValueOrDefault(firstChar);
        if (existingTrie == null)
        {
          Trie newTrie = new Trie(firstChar);
          this.Links.Add(firstChar, newTrie);
          newTrie.Add(rest);
        }
        else
        {
          existingTrie.Add(rest);
        }
      }
    }
  }
}
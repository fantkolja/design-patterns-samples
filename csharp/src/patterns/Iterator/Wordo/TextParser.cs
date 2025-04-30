using System.Text.RegularExpressions;

namespace DesignPatterns.Iterator
{
  static class TextParser
  {
    public static void Parse(string src, Action<string> callback)
    {
      using(StreamReader file = new StreamReader(src))
      {
        string? line = null;
        while((line = file.ReadLine()) != null)
        {
          foreach(string word in Regex.Split(line, "[^a-zA-Z]+"))
          {
            // filter out 1-letter words and lowercase it
            string normalizedWord = word.ToLower();
            if (normalizedWord.Length > 1)
            {
              callback(normalizedWord);
            }
          }
        }
        file.Close();
      }
    }
    public static SortedDictionary<string, string> GetWordDictionary(string src)
    {
      SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
      TextParser.Parse(src, (normalizedWord) => {
        if (dictionary.GetValueOrDefault(normalizedWord) == null)
        {
          dictionary.Add(normalizedWord, normalizedWord);
        }
      });
      return dictionary;
    }
    public static Trie GetWordTrie(string src)
    {
      Trie dictionary = new Trie('\n');
      TextParser.Parse(src, (normalizedWord) => {
        if (!dictionary.Contains(normalizedWord))
        {
          dictionary.Add(normalizedWord);
        }
      });
      return dictionary;
    }
  }
}


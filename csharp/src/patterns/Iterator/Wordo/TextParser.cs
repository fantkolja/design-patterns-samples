using System.Text.RegularExpressions;

namespace DesignPatterns.Iterator
{
  static class TextParser
  {
    // @TODO: return IEnumerator
    public static SortedDictionary<string, string> GetWordList(string src)
    {
      using(StreamReader file = new StreamReader(src))
      {
        SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
        string? line = null;
        while((line = file.ReadLine()) != null)
        {
          foreach(string word in Regex.Split(line, "[^a-zA-Z]+"))
          {
            // filter out 1-letter words and lowercase it
            string normalizedWord = word.ToLower();
            if (normalizedWord.Length > 1)
            {
              if (dictionary.GetValueOrDefault(normalizedWord) == null)
              {
                dictionary.Add(normalizedWord, normalizedWord);
              }
            }
          }
        }
        file.Close();
        return dictionary;
      }
    }

    // using DesignPatterns.Iterator;

    // var dictionary = TextParser.GetWordList("./tmp/little_women.txt");

    // Console.WriteLine("");
    // Console.WriteLine("*******************");
    // Console.WriteLine($"Dictionary size: {dictionary.Count}");
    // Console.WriteLine("*******************");
    // Console.WriteLine("");

    // await DictionaryWriter.WriteToFileAsync(dictionary, "./tmp/little_women.dict.txt");























    public static Trie GetWordTrie(string src)
    {
      using(StreamReader file = new StreamReader(src))
      {
        Trie dictionary = new Trie('\0');
        string? line = null;
        while((line = file.ReadLine()) != null)
        {
          foreach(string word in Regex.Split(line, "[^a-zA-Z]+"))
          {
            // filter out 1-letter words and lowercase it
            string normalizedWord = word.ToLower();
            if (normalizedWord.Length > 1 && !dictionary.Contains(normalizedWord))
            {
              dictionary.Add(normalizedWord);
            }
          }
        }
        file.Close();
        return dictionary;
      }
    }
  }
}
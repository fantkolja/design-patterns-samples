using System.Text.RegularExpressions;

namespace DesignPatterns.Iterator
{
  static class TextParser
  {
    // @TODO: return IEnumerator
    public static List<string> GetWordList(string src)
    {
      using(StreamReader file = new StreamReader(src))
      {
        List<string> dictionary = new List<string>();
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
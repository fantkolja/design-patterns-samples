using System.Text.RegularExpressions;

namespace DesignPatterns.Iterator
{
  static class DictionaryWriter
  {
    public static async Task WriteToFileAsync(List<string> dictionary, string src)
    {
      using (StreamWriter writer = new StreamWriter(src))  
      {
        foreach(string word in dictionary)
        {
          await writer.WriteLineAsync(word);
        }
        writer.Close();
      }
    }
  }
}
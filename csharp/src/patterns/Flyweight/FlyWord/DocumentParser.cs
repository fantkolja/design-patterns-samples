namespace DesignPatterns.Flyweight
{
  class DocumentParser
  {
    private List<List<Letter>> _text = new List<List<Letter>>();
    private void _readFile(string src)
    {
      using(StreamReader file = new StreamReader(src)) {
        ulong lineNumber = 0;
        string? nextLine;

        while((nextLine = file.ReadLine()) != null)
        {
          var nextLineList = new List<Letter>();
          this._text.Insert((int) lineNumber, nextLineList);
          ulong caretPosition = 0;
          nextLine.ToList().ForEach((char c) => {
            nextLineList.Insert((int) caretPosition, new Letter("Times New Roman", c, (lineNumber, caretPosition), "Little Women"));
            caretPosition++;
          });
          lineNumber++;
        };

        file.Close();
      }
    }

    public DocumentParser()
    {
      Console.WriteLine("Checking memory BEFORE document load...");
      MemoryMonitor.CheckCurrentProcess();
      this._readFile("./tmp/little_women.txt");
      Console.WriteLine($"Lines: {this._text.Count}");
      Console.WriteLine("Checking memory AFTER document load...");
      MemoryMonitor.CheckCurrentProcess();
    }

    public Letter? GetLetterAt(int row, int column)
    {
      try 
      {
        return this._text[row][column];
      }
      catch (Exception)
      {
        return null;
      }
    }
  }
}


// using DesignPatterns.Flyweight;

// var parser = new DocumentParser();

// var letter = parser.GetLetterAt(49, 1);

// if (letter is Letter)
// {
//   Console.WriteLine($"DisplayName: {letter.DisplayName}; CharCode: {letter.CharCode}");
// }
// else 
// {
//   Console.WriteLine("There is no such letter");
// }

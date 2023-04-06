namespace DesignPatterns.Flyweight
{
  class DocumentParser
  {
    private List<Letter> _text = new List<Letter>();
    private void _readFile(string src)
    {
      using(StreamReader file = new StreamReader(src)) {
        int lineNumber = 0;
        string? nextLine;

        while((nextLine = file.ReadLine()) != null)
        {
          lineNumber++;
          int carretPosition = 0;
          nextLine.ToList().ForEach((char c) => {
            this._text.Add(new Letter("Times New Roman", c, (lineNumber, carretPosition), "Little Women"));
            carretPosition++;
          });
        };

        file.Close();
      }
    }

    public DocumentParser()
    {
      Console.WriteLine("Checking memory BEFORE document load...");
      MemoryMonitor.CheckCUrrentProcess();
      this._readFile("./tmp/little_women.txt");
      Console.WriteLine("Checking memory AFTER document load...");
      MemoryMonitor.CheckCUrrentProcess();
    }
  }
}
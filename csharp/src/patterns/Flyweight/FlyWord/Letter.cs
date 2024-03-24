namespace DesignPatterns.Flyweight
{
  class Letter
  {
    public string FontStyle { get; private set; } = "normal";
    public int FontSize { get; private set; } = 12;
    public int FontWeight { get; private set; } = 400;
    public string FontColor { get; private set; } = "#000";
    public string TextDecoration { get; private set; } = "normal";
    public string FromAlphabet { get; private set; } = "latin";
    public string Type { get; private set; } = "Alphabetic";
    public int CharCode { get; private set; }
    public string DisplayName { get; private set; }
    public (ulong, ulong) CurrentPosition { get; private set; }
    public (ulong, ulong) OriginalPosition { get; private set; }
    public string OriginalDocument { get; private set; }
    public string FontFamily { get; private set; }
    public Letter(string fontFamily, char character, (ulong, ulong) position, string originalDocument)
    {
      this.FontFamily = fontFamily;
      this.CharCode = (int) character;
      this.DisplayName = character.ToString();
      this.OriginalPosition = position;
      this.CurrentPosition = position;
      this.OriginalDocument = originalDocument;
    }
  }
}
































// Attempt #1 unique letter


// namespace DesignPatterns.Flyweight
// {
//   class Letter
//   {
//     private UniqueLetter _uniqueLetter;
//     public string FontStyle { get; private set; } = "normal";
//     public int FontSize { get; private set; } = 12;
//     public int FontWeight { get; private set; } = 400;
//     public string FontColor { get; private set; } = "#000";
//     public string TextDecoration { get; private set; } = "normal";
//     public (ulong, ulong) CurrentPosition { get; private set; }
    
//     // intrinsic!
//     public (ulong, ulong) OriginalPosition { get; private set; }
    
//     // intrinsic!
//     public string OriginalDocument { get; private set; }
    
//     public string FontFamily { get; private set; }
//     public Letter(string fontFamily, char character, (ulong, ulong) position, string originalDocument)
//     {
//       this.FontFamily = fontFamily;
//       this.CurrentPosition = position;
//       this.OriginalPosition = position;
//       this.OriginalDocument = originalDocument;
//       this._uniqueLetter = UniqueLetterFactory.GetUniqueLetter(character);
//     }
//   }

//   class UniqueLetter
//   {
//     public string FromAlphabet { get; private set; } = "latin";
//     public string Type { get; private set; } = "Alphabetic";
//     public int CharCode { get; private set; }
//     public string DisplayName { get; private set; }

//     public UniqueLetter(char character)
//     {
//       this.CharCode = (int)character;
//       this.DisplayName = character.ToString();
//     }
//   }

//   static class UniqueLetterFactory
//   {
//     private static Dictionary<int, UniqueLetter> _uniqueLettersPool = new Dictionary<int, UniqueLetter>();
//     public static UniqueLetter GetUniqueLetter(char character)
//     {
//       int id = (int) character;
//       UniqueLetter? uniqueLetter = UniqueLetterFactory._uniqueLettersPool.GetValueOrDefault(id);
//       if (uniqueLetter == null)
//       {
//         uniqueLetter = new UniqueLetter(character);
//         UniqueLetterFactory._uniqueLettersPool[id] = uniqueLetter;
//       }
//       return uniqueLetter;
//     }
//   }
// }
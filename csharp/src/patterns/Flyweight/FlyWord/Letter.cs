namespace DesignPatterns.Flyweight
{
  class Letter
  {
    public string FontStyle { get; set; } = "normal";
    public int FontSize { get; set; } = 12;
    public int FontWeight { get; set; } = 400;
    public string FontFamily { get; set; }
    public string FontColor { get; set; } = "#000";
    public string TextDecoration { get; set; } = "normal";
    public string FromAlphabet { get; } = "latin";
    public string Type { get; } = "Alphabetic";
    public int CharCode { get; }
    public string DisplayName { get; }
    public (int, int) CurrentPosition { get; set; }
    public (int, int) OriginalPosition { get; }
    public string OriginalDocument { get; }
    public Letter(string fontFamily, char character, (int, int) position, string originalDocument)
    {
      this.FontFamily = fontFamily;
      this.CharCode = (int)character;
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
//     public string FontStyle { get; set; } = "normal";
//     public int FontSize { get; set; } = 12;
//     public int FontWeight { get; set; } = 400;
//     public string FontColor { get; set; } = "#000";
//     public string FontFamily { get; set; }
//     public string TextDecoration { get; set; } = "normal";
//     public (int, int) CurrentPosition { get; set; }

//     // intrinsic!
//     public (int, int) OriginalPosition { get; }

//     // intrinsic!
//     public string OriginalDocument { get; }

//     public Letter(string fontFamily, char character, (int, int) position, string originalDocument)
//     {
//       this.FontFamily = fontFamily;
//       this.CurrentPosition = position;
//       this.OriginalPosition = position;
//       this.OriginalDocument = originalDocument;
//       this._uniqueLetter = UniqueLetterFactory.GetUniqueLetter(character);
//     }
//     public string FromAlphabet
//     {
//       get { return _uniqueLetter.FromAlphabet; }
//     }
//     public string Type
//     {
//       get { return _uniqueLetter.Type; }
//     }
//     public int CharCode
//     {
//       get { return _uniqueLetter.CharCode; }
//     }
//     public string DisplayName
//     {
//       get { return _uniqueLetter.DisplayName; }
//     }
//   }

//   class UniqueLetter
//   {
//     public string FromAlphabet { get; } = "latin";
//     public string Type { get; } = "Alphabetic";
//     public int CharCode { get; }
//     public string DisplayName { get; }

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
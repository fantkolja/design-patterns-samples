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
    public (long, int) CurrentPosition { get; private set; }
    public (long, int) OriginalPosition { get; private set; }
    public string OriginalDocument { get; private set; }
    public string FontFamily { get; private set; }
    public Letter(string fontFamily, char character, (long, int) position, string originalDocument)
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




































// namespace DesignPatterns.Flyweight
// {
//   class Letter
//   {
//     private LetterType _letterType;
//     public string FontStyle { get; private set; } = "normal";
//     public int FontSize { get; private set; } = 12;
//     public int FontWeight { get; private set; } = 400;
//     public string FontColor { get; private set; } = "#000";
//     public string TextDecoration { get; private set; } = "normal";
//     public (long, int) CurrentPosition { get; private set; }
//     public (long, int) OriginalPosition { get; private set; }
//     public string FontFamily { get; private set; }
//     public Letter(string fontFamily, char character, (long, int) position, string originalDocument)
//     {
//       this.FontFamily = fontFamily;
//       this.CurrentPosition = position;
//       this.OriginalPosition = position;
//       this._letterType = LetterTypeFabric.GetLetterType(character, originalDocument);
//     }
//   }

//   class LetterType
//   {
//     public string FromAlphabet { get; private set; } = "latin";
//     public string Type { get; private set; } = "Alphabetic";
//     public int CharCode { get; private set; }
//     public string DisplayName { get; private set; }
//     public string OriginalDocument { get; private set; }

//     public LetterType(char character, string originalDocument)
//     {
//       this.CharCode = (int)character;
//       this.OriginalDocument = originalDocument;
//       this.DisplayName = character.ToString();
//     }
//   }

//   static class LetterTypeFabric
//   {
//     private static Dictionary<int, LetterType> _letterTypesPool = new Dictionary<int, LetterType>();
//     public static LetterType GetLetterType(char character, string originalDocument)
//     {
//       int id = (int) character;
//       LetterType? letterType = LetterTypeFabric._letterTypesPool.GetValueOrDefault(id);
//       if (letterType == null)
//       {
//         letterType = new LetterType(character, originalDocument);
//         LetterTypeFabric._letterTypesPool[id] = letterType;
//       }
//       return letterType;
//     }
//   }
// }
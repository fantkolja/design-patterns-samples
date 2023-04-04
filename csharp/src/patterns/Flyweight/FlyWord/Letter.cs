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
    public string CharType { get; private set; } = "Alphabetic";
    public int CharCode { get; private set; }
    public (ulong, ulong) CurrentPosition { get; private set; }
    public (ulong, ulong) OriginalPosition { get; private set; }
    public string FontFamily { get; private set; }
    public Letter(string fontFamily, int charCode, (ulong, ulong) position)
    {
      this.FontFamily = fontFamily;
      this.CharCode = charCode;
      this.OriginalPosition = position;
      this.CurrentPosition = position;
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
//     public (ulong, ulong) CurrentPosition { get; private set; }
//     public string FontFamily { get; private set; }
//     public Letter(string fontFamily, int charCode, (ulong, ulong) position)
//     {
//       this.FontFamily = fontFamily;
//       this.CurrentPosition = position;
//       this._letterType = LetterTypeFabric.GetLetterType(charCode, position);
//     }
//   }

//   class LetterType
//   {
//     public string FromAlphabet { get; private set; } = "latin";
//     public string CharType { get; private set; } = "Alphabetic";
//     public int CharCode { get; private set; }
//     public (ulong, ulong) OriginalPosition { get; private set; }

//     public LetterType(int charCode, (ulong, ulong) position)
//     {
//       this.CharCode = charCode;
//       this.OriginalPosition = position;
//     }
//   }

//   static class LetterTypeFabric
//   {
//     private static Dictionary<int, LetterType> _letterTypesPool = new Dictionary<int, LetterType>();
//     public static LetterType GetLetterType(int charCode, (ulong, ulong) position)
//     {
//       LetterType? letterType = LetterTypeFabric._letterTypesPool.GetValueOrDefault(charCode);
//       if (letterType == null)
//       {
//         letterType = new LetterType(charCode, position);
//         LetterTypeFabric._letterTypesPool[charCode] = letterType;
//       }
//       return letterType;
//     }
//   }
// }
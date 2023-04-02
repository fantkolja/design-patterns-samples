using System.Text;

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
    public (long, int) CurrentPosition { get; private set; }
    public (long, int) OriginalPosition { get; private set; }
    public string FontFamily { get; private set; }
    public Letter(string fontFamily, int charCode, (long, int) position)
    {
      this.FontFamily = fontFamily;
      this.CharCode = charCode;
      this.OriginalPosition = position;
      this.CurrentPosition = position;
    }
  }
}
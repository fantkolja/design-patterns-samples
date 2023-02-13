namespace ProgrammingPrinciples.SOLID
{
  class LSPDemo
  {
    private static int calculateArea(Rectangle rect)
    {
      return rect.Width * rect.Height;
    }
    public static void show()
    {
      Rectangle rect = new Square();
      rect.Width = 4;
      // rect.Height = 5;

      Console.WriteLine(calculateArea(rect));
    }
  }
}

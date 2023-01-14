namespace ProgrammingPrinciples.SOLID
{
  class Rectangle
  {
    public int Width { get; set; }
    public int Height { get; set; }
  }

  class Square : Rectangle
  {
    public new int Width {
      set { base.Width = base.Height = value; }
    }
    public new int Height {
      set { base.Height = base.Width = value; }
    }
  }
}
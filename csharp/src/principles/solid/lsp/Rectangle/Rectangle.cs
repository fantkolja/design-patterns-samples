namespace ProgrammingPrinciples.SOLID
{
  class Rectangle
  {
    // public int Width { get; set; }
    // public int Height { get; set; }

    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
  }

  class Square : Rectangle
  {
    public override int Width {
      set { base.Width = base.Height = value; }
    }
    public override int Height {
      set { base.Height = base.Width = value; }
    }
  }
}
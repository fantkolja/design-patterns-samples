// fit different objects into a hole

namespace DesignPatterns.Adapter
{
  class Cylinder
  {
    public int Radius { get; }

    public Cylinder(int radius)
    {
      this.Radius = radius;
    }
  }

  class RoundHole
  {
    private int _radius;

    public RoundHole(int radius)
    {
      this._radius = radius;
    }

    public bool Fits(Cylinder shape)
    {
      return shape.Radius <= this._radius;
    }
  }
}






// Feature Request: support Cuboids

  // class Cuboid
  // {
  //   public int Width { get; }
  //   public Cuboid(int width)
  //   {
  //     this.Width = width;
  //   }
  // }
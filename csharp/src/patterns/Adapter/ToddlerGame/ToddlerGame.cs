// fit different objects into a hole

namespace DesignPatterns.Adapter
{
  class Cylinder
  {
    public double Radius { get; }

    public Cylinder(double radius)
    {
      this.Radius = radius;
    }
  }

  class RoundHole
  {
    private double _radius;

    public RoundHole(double radius)
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
  //   public double Width { get; }
  //   public Cuboid(double width)
  //   {
  //     this.Width = width;
  //   }
  // }






















// namespace DesignPatterns.Adapter
// {
//   class Cuboid
//   {
//     public double Width { get; }
//     public Cuboid(double width)
//     {
//       this.Width = width;
//     }
//   }

//   class CuboidAdapter : Cylinder
//   {
//     private Cuboid _cuboid;
//     public CuboidAdapter(Cuboid cuboid) : base(cuboid.Width * Math.Sqrt(2) / 2)
//     {
//       this._cuboid = cuboid;
//     }
//   }
// }
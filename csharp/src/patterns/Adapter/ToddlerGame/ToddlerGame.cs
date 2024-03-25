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



// using DesignPatterns.Adapter;

// var smallShape = new Cylinder(5);
// var bigShape = new Cylinder(8);
// var hole = new RoundHole(6);

// Console.WriteLine(hole.Fits(smallShape));
// Console.WriteLine(hole.Fits(bigShape));




// Feature Request: support Cuboids

namespace DesignPatterns.Adapter
{
  class Cuboid
  {
    public double Width { get; }
    public Cuboid(double width)
    {
      this.Width = width;
    }
  }
}




// Attempt #1
// use method overloading

// Drawbacks:
// 1. RoundHole knows too much about new objects
// 2. Breaks OCP
// 3. Complicates rollback in case a new object is removed in the future

// namespace DesignPatterns.Adapter
// {
//   class RoundHole
//   {
//     // ...
//     public bool Fits(Cuboid shape)
//     {
//       return shape.Width * Math.Sqrt(2) / 2 <= this._radius;
//     }
//   }
// }
















// namespace DesignPatterns.Adapter
// {
//   class CuboidAdapter : Cylinder
//   {
//     private Cuboid _cuboid;
//     public CuboidAdapter(Cuboid cuboid) : base(cuboid.Width * Math.Sqrt(2) / 2)
//     {
//       this._cuboid = cuboid;
//     }
//   }
// }
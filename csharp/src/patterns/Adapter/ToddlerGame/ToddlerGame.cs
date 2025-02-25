// fit different objects into a hole

namespace DesignPatterns.Adapter
{
  class Cylinder
  {
    private double _radius;

    public Cylinder(double radius)
    {
      this._radius = radius;
    }

    public double GetRadius()
    {
      return _radius;
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
      return shape.GetRadius() <= this._radius;
    }
  }
}



// using DesignPatterns.Adapter;

// var smallShape = new Cylinder(5);
// var bigShape = new Cylinder(8);
// var hole = new RoundHole(6);

// Console.WriteLine(hole.Fits(smallShape));
// Console.WriteLine(hole.Fits(bigShape));




// Feature Request: support SquareBasedCuboids

namespace DesignPatterns.Adapter
{
  class SquareBasedCuboid
  {
    private double _width;
    public SquareBasedCuboid(double width)
    {
      this._width = width;
    }
    public double GetWidth()
    {
      return _width;
    }
  }
}


// using DesignPatterns.Adapter;

// var smallShape = new Cylinder(5);
// var bigShape = new Cylinder(8);
// var hole = new RoundHole(6);

// var smallCuboid = new SquareBasedCuboid(5);
// var bigCuboid = new SquareBasedCuboid(10);

// Console.WriteLine(hole.Fits(smallShape));
// Console.WriteLine(hole.Fits(bigShape));

// Console.WriteLine(hole.Fits(smallCuboid));
// Console.WriteLine(hole.Fits(bigCuboid));




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
//     public bool Fits(SquareBasedCuboid shape)
//     {
//       return Math.Sqrt(2 * Math.Pow(shape.GetWidth(), 2)) / 2 <= this._radius;
//     }
//   }
// }
















// namespace DesignPatterns.Adapter
// {
//   class SquareBasedCuboidAdapter : Cylinder
//   {
//     static private double _calculateRadiusFromWidth(double width)
//     {
//       return Math.Sqrt(2 * Math.Pow(width, 2)) / 2;
//     }
//     private SquareBasedCuboid _squareBasedCuboid;
//     public SquareBasedCuboidAdapter(SquareBasedCuboid squareBasedCuboid)
//      : base(_calculateRadiusFromWidth(squareBasedCuboid.GetWidth()))
//     {
//       this._squareBasedCuboid = squareBasedCuboid;
//     }
//   }
// }


// using DesignPatterns.Adapter;

// var smallShape = new Cylinder(5);
// var bigShape = new Cylinder(8);
// var hole = new RoundHole(6);

// var smallCuboid = new SquareBasedCuboid(5);
// var bigCuboid = new SquareBasedCuboid(10);

// var smallCubiodAdapter = new SquareBasedCuboidAdapter(smallCuboid);
// var bigCubiodAdapter = new SquareBasedCuboidAdapter(bigCuboid);

// Console.WriteLine(hole.Fits(smallShape));
// Console.WriteLine(hole.Fits(bigShape));

// Console.WriteLine(hole.Fits(smallCubiodAdapter));
// Console.WriteLine(hole.Fits(bigCubiodAdapter));
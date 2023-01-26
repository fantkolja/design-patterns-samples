// namespace DesignPatterns.FactoryMethod
// {
//   class Point
//   {
//     public enum CoordinatesSystem
//     {
//       Cartesian,
//       Polar,
//     }

//     private double _a;
//     private double _b;
//     private CoordinatesSystem _type;


//     public Point(double x, double y)
//     {
//       this._a = x;
//       this._b = y;
//       this._type = CoordinatesSystem.Cartesian;
//     }

//     public Point(double rho, double theta, CoordinatesSystem type)
//     {
//       this._a = rho * Math.Sin(theta);
//       this._b = rho * Math.Sin(theta);
//       this._type = type;
//     }
//   }
// }

namespace DesignPatterns.FactoryMethod
{
  class Point
  {
    private double _a;
    private double _b;

    private Point(double a, double b)
    {
      this._a = a;
      this._b = b;
    }

    public static Point GetCartesianPoint(double x, double y)
    {
      return new Point(x, y);
    }
    public static Point GetPolarPoint(double rho, double theta)
    {
      return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
  }
}
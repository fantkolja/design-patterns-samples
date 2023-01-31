// namespace DesignPatterns.FactoryMethod
// {
//   class Point
//   {
//     public enum CoordinatesSystem
//     {
//       Cartesian,
//       Polar,
//     }

//     private double _x;
//     private double _y;
//     private CoordinatesSystem _type;


//     public Point(double x, double y)
//     {
//       this._x = x;
//       this._y = y;
//       this._type = CoordinatesSystem.Cartesian;
//     }

//     public Point(double rho, double theta, CoordinatesSystem type)
//     {
//       this._x = rho * Math.Sin(theta);
//       this._y = rho * Math.Sin(theta);
//       this._type = type;
//     }
//   }
// }

namespace DesignPatterns.FactoryMethod
{
  class Point
  {
    private const int APPOXIMITY = 1;
    private double _x;
    private double _y;

    private Point(double a, double b)
    {
      this._x = a;
      this._y = b;
    }

    public static Point GetCartesianPoint(double x, double y)
    {
      return new Point(x, y);
    }
    public static Point GetPolarPoint(double rho, double theta)
    {
      return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }

    public static Point operator + (Point p1, Point p2)
    {
      return new Point(p1._x + p2._x, p1._y + p2._y);
    }

    public static Point operator - (Point p1, Point p2)
    {
      return new Point(p1._x - p2._x, p1._y - p2._y);
    }

    // public static bool operator == (Point p1, Point p2)
    // {
    //   return Math.Abs(p1._x - p2._x) <= APPOXIMITY && Math.Abs(p1._y - p2._y) <= APPOXIMITY;
    // }

    // public static bool operator != (Point p1, Point p2)
    // {
    //   return Math.Abs(p1._x - p2._x) > APPOXIMITY && Math.Abs(p1._y - p2._y) > APPOXIMITY;
    // }
  }
}
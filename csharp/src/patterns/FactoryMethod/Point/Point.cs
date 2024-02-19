namespace DesignPatterns.FactoryMethod
{
  class Point
  {
    private double _x;
    private double _y;


    public Point(double x, double y)
    {
      this._x = x;
      this._y = y;
    }
  }
}

// new requirement: support Polar Coordinates System


























// Attempt 2 with type and if
// ANTI-SAMPLE!!!

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


//     public Point(double x, double y, CoordinatesSystem type)
//     {
//       if (type == CoordinatesSystem.Cartesian)
//       {
//         this._x = x;
//         this._y = y;
//       }
//       else
//       {
//         // in this case `x` and `y` mean something different => `rho` and `theta`
//         // it looks weird
//         double rho = x;
//         double theta = y;
//         this._x = rho * Math.Cos(theta);
//         this._y = rho * Math.Sin(theta);
//       }
//     }
//   }
// }









// Attempt 3 with constructor overload
// ANTI-SAMPLE!!!

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


//     public Point(double x, double y, CoordinatesSystem type)
//     {
//       this._x = x;
//       this._y = y;
//     }

//     public Point(double rho, double theta, CoordinatesSystem type)
//     {
//       this._x = rho * Math.Cos(theta);
//       this._y = rho * Math.Sin(theta);
//     }
//   }
// }









// namespace DesignPatterns.FactoryMethod
// {
//   class Point
//   {
//     private double _x;
//     private double _y;

//     // constructor can be private to descrease usage complexity
//     // calling the variables `a` and `b` to make them polysemic
//     private Point(double a, double b)
//     {
//       this._x = a;
//       this._y = b;
//     }

//     public static Point GetCartesianPoint(double x, double y)
//     {
//       return new Point(x, y);
//     }
//     public static Point GetPolarPoint(double rho, double theta)
//     {
//       return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
//     }





//     // we can still use private constructor internally
//     public Point Plus(Point anotherPoint)
//     {
//       return new Point(this._x + anotherPoint._x, this._y + anotherPoint._y);
//     }

//     public Point Minus(Point anotherPoint)
//     {
//       return new Point(this._x - anotherPoint._x, this._y - anotherPoint._y);
//     }
//   }
// }





// using DesignPatterns.FactoryMethod;

// // Point cartesianPoint = new Point(1, 2);
// // Point polarPoint = new Point(1, 2, Point.CoordinatesSystem.Polar);

// Point cartesianPoint = Point.GetCartesianPoint(1, 2);
// Point polarPoint = Point.GetPolarPoint(1, 2);

// Point newPoint = cartesianPoint.Plus(polarPoint);
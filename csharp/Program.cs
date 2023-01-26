using System;
using ProgrammingPrinciples;
using DesignPatterns.FactoryMethod;

Point cartesianPoint = Point.GetCartesianPoint(1, 2);
Point polarPoint = Point.GetPolarPoint(1.0, Math.PI / 2);


Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
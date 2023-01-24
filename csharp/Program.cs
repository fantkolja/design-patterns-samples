using System;
using ProgrammingPrinciples;
using DesignPatterns.Builder;

ClassicBuilder builder = new ConcreteClassicBuilder();
ClassicDirector director = new ClassicDirector(builder);

ClassicProduct fullFeaturedProduct = director.GetFullFeaturedProduct();
ClassicProduct mvpProduct = director.GetMvpProduct();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
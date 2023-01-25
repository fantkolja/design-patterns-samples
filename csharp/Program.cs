using System;
using ProgrammingPrinciples;
using DesignPatterns.Builder;

Car car = CarBuilder.Create()
  .WithEngine("1.6MPI")
  .WithTransmission("ZTF-8")
  .HavingWheelSize(16)
  .InColor("white")
  .Build();

Car car2 = CarBuilder.Create()
  .WithEngine("1.6MPI")
  .HavingWheelSize(16)
  .WithTransmission("ZTF-8")
  .InColor("white")
  .Build();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
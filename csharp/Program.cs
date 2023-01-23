using System;
using ProgrammingPrinciples;
using DesignPatterns.Builder;

Pizza pz = new Pizza(
  "mukhomor",
  "mascarpone",
  "chicken",
  null,
  null,
  null,
  32,
  2
);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
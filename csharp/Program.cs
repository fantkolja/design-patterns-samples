using System;
using ProgrammingPrinciples;
using DesignPatterns.Builder;

PizzaBuilder pizzaBuilder = new HousePizzaBuilder();
PizzaDirector pizzaDirector = new PizzaDirector(pizzaBuilder);

Pizza neapolitana = pizzaDirector.GetNeapolitanaPizza();
Pizza drive = pizzaDirector.GetDrivePizza();

Console.WriteLine(neapolitana);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
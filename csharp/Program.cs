using System;
using ProgrammingPrinciples;
using DesignPatterns.Prototype;


var photo = new Photo("url");
var idCard = new IDCard(photo);
var vasya = new Person(new[] { "Vasyl", "Petrovych", "Petrenko" }, idCard);

var kolya = (Person) vasya.Clone();
// kolya.Names = new[] { "Mykola", "Mykolajovych", "Mykolenko" };
kolya.Names.SetValue("Mykola", 0);
kolya.IDCard.ID = Guid.NewGuid();
kolya.IDCard.Photo.Url = "kolya";

Console.WriteLine(vasya);
Console.WriteLine(kolya);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
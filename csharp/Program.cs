using System;
using ProgrammingPrinciples;
using DesignPatterns.Prototype;
using DesignPatterns.Protoype.ExtensionMethods;


var photo = new Photo("photo-of-vasya.jpg");
var idCard = new IDCard(photo);
var vasya = new Person(new[] { "Vasyl", "Petrovych", "Petrenko" }, idCard);

var kolya = (Person) vasya.DeepClone();
// kolya.Names = new[] { "Mykola", "Mykolajovych", "Mykolenko" };
kolya.Names.SetValue("Mykola", 0);
kolya.Names.SetValue("Mykolajovych", 1);
kolya.Names.SetValue("Mykolenko", 2);
kolya.IDCard.ID = Guid.NewGuid();
kolya.IDCard.Photo.Url = "photo-of-kolya.jpg";

Console.WriteLine(vasya);
Console.WriteLine(kolya);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
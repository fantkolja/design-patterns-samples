namespace DesignPatterns.Prototype
{
  interface IClassicPrototype
  {
    IClassicPrototype Clone();
  }
}

// using DesignPatterns.Prototype;

// IClassicPrototype original = new ConcretePrototype("original");
// var copy = (ConcretePrototype) original.Clone();

// IClassicPrototype originalSub = new SubclassPrototype("originalSub", 23);
// var copySub = (SubclassPrototype) originalSub.Clone();

// copy.SetName("copy");
// copySub.SetName("copySub");
// copySub.SetAge(21);

// Console.WriteLine(original);
// Console.WriteLine(copy);
// Console.WriteLine();

// Console.WriteLine(originalSub);
// Console.WriteLine(copySub);
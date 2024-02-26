using DesignPatterns.Prototype;

var photo = new Photo("https://cool-photo");
var idCard = new IDCard(photo);
var mykola = new Person(new[] { "Mykola", "Fant" }, idCard);

Console.WriteLine(mykola);

var clonoKolya = (Person) mykola.Clone();
clonoKolya.Names[0] = "Kolya";

Console.WriteLine(clonoKolya);
Console.WriteLine(mykola);

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
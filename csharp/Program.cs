using DesignPatterns.Composite;

var gloveOfPower = new ArtefactWithArtefacts("Glove Of Power", 500, 1000);
var sword = new Artefact("Sword", 50, 500);
var pants = new Artefact("Pants", 10, 100);

gloveOfPower.AddArtefact(sword);
gloveOfPower.AddArtefact(pants);

Console.WriteLine(gloveOfPower.GetWeight());
Console.WriteLine(gloveOfPower.GetCount());

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
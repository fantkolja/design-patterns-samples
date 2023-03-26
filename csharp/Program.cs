using DesignPatterns.Composite;

var princess = new MarvelHero("Ira", 1);
var ring = new Artefact("PowerRing", 5, 50);
var necklace = new Artefact("PerlNecklace", 10, 100);
var husband = new CompositeArtefact("Thanos", 1000, 1000);

husband.AddArtefact(ring);
husband.AddArtefact(necklace);

princess.AddArtefact(husband);


princess.CountArtefacts();
princess.CalculateArtefactsWeight();
princess.Strike();

husband.RemoveArtefact(ring);
princess.CountArtefacts();
princess.CalculateArtefactsWeight();
princess.Strike();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
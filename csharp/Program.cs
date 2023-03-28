using DesignPatterns.Composite;

var hero = new MarvelHero("BlackWidow", 1);
var ring = new Artefact("PowerRing", 5, 50);
var necklace = new Artefact("PerlNecklace", 10, 100);

hero.AddArtefact(ring);
hero.AddArtefact(necklace);

hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();

hero.RemoveArtefact(ring);
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();


Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
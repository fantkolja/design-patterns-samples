using System;
using ProgrammingPrinciples;
using DesignPatterns.FactoryMethod;


RandomArtefactCreator creator = new();
const int N = 100;
Artefact[] artefactPool = new Artefact[N];

for(int i = 0; i < N; i++)
{
  artefactPool.SetValue(creator.CreateRandomArtefact(), i);
}

Artefact[] swords = artefactPool.Where(artefact => artefact.GetType() == typeof(Sword)).ToArray();
Artefact[] gloves = artefactPool.Where(artefact => artefact.GetType() == typeof(Gloves)).ToArray();
Artefact[] rings = artefactPool.Where(artefact => artefact.GetType() == typeof(Ring)).ToArray();

Console.WriteLine($"Swords count: {swords.Length};\nGloves count: {gloves.Length};\nRings count: {rings.Length};\n");


Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
namespace DesignPatterns.FactoryMethod
{
  class RandomArtefactCreator
  {
    private enum ArtefactKind
    {
      Sword,
      Gloves,
      Ring,
    }

    private ArtefactKind _getRandomArtefactKind()
    {
      Random random = new();
      Array values = Enum.GetValues(typeof(ArtefactKind));
      int index = random.Next(values.Length);
      return (ArtefactKind)values.GetValue(index);
    }

    public Artefact CreateRandomArtefact()
    {
      ArtefactKind kind = this._getRandomArtefactKind();
      switch(kind)
      {
        case ArtefactKind.Sword:
          return new Sword();
        case ArtefactKind.Gloves:
          return new Gloves();
        case ArtefactKind.Ring:
          return new Ring();
        default:
          throw new NotImplementedException($"Unknown artefact kind {kind}");
      }
    }
  }
}

// RandomArtefactCreator creator = new();
// const int N = 100;
// Artefact[] artefactPool = new Artefact[N];

// for(int i = 0; i < N; i++)
// {
//   artefactPool.SetValue(creator.CreateRandomArtefact(), i);
// }

// Artefact[] swords = artefactPool.Where(artefact => artefact.GetType() == typeof(Sword)).ToArray();
// Artefact[] gloves = artefactPool.Where(artefact => artefact.GetType() == typeof(Gloves)).ToArray();
// Artefact[] rings = artefactPool.Where(artefact => artefact.GetType() == typeof(Ring)).ToArray();

// Console.WriteLine($"Swords count: {swords.Length};\nGloves count: {gloves.Length};\nRings count: {rings.Length};\n");
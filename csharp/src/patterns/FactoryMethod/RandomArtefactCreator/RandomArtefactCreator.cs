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
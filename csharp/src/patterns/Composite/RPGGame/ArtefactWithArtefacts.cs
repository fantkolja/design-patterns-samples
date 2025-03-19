namespace DesignPatterns.Composite
{
  class ArtefactWithArtefacts : CompositeArtefact
  {
    public ArtefactWithArtefacts(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
    {
    }

    public override int GetCount()
    {
      return this._children.Aggregate(1, (sum, next) => sum += next.GetCount());
    }
  }
}

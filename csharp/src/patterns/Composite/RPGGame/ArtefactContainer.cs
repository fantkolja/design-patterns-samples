namespace DesignPatterns.Composite
{
  class ArtefactContainer : CompositeArtefact
  {
    public ArtefactContainer(string name) : base(name, 0, 0)
    {
    }

    public override int GetCount()
    {
      return this._children.Aggregate(0, (sum, next) => sum += next.GetCount());
    }
  }
}

namespace DesignPatterns.Composite
{
  class ArtefactWithArtefacts : CompositeArtefact
  {
    public ArtefactWithArtefacts(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
    {
    }

    public override int GetWeight()
    {
      return this._children.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
    }

    public override int GetPowerBuf()
    {
      return this._children.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
    }

    public override int GetCount()
    {
      return this._children.Aggregate(1, (sum, next) => sum += next.GetCount());
    }
  }
}

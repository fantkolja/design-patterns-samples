namespace DesignPatterns.Composite
{
  class ContainerArtefact : CompositeArtefact
  {
    public ContainerArtefact(string name) : base(name, 0, 0)
    {
    }

    public override int GetWeight()
    {
      return this._children.Aggregate(0, (sum, next) => sum += next.GetWeight());
    }

    public override int GetPowerBuf()
    {
      return this._children.Aggregate(0, (sum, next) => sum += next.GetPowerBuf());
    }

    public override int GetCount()
    {
      return this._children.Aggregate(0, (sum, next) => sum += next.GetCount());
    }
  }
}

namespace DesignPatterns.Composite
{
  class Artefact
  {
    public string Name { get; protected set; }
    protected int _weight;
    protected int _powerBuf;

    public Artefact(string name, int weight, int powerBuf)
    {
      this.Name = name;
      this._weight = weight;
      this._powerBuf = powerBuf;
    }

    public virtual int GetWeight()
    {
      return this._weight;
    }

    public virtual int GetPowerBuf()
    {
      return this._powerBuf;
    }

    public virtual int GetCount()
    {
      return 1;
    }
  }
}
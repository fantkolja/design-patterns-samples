namespace DesignPatterns.Prototype
{
  class ConcretePrototype : IClassicPrototype
  {
    private string _name;
    public ConcretePrototype(string name)
    {
      this._name = name;
    }
    public ConcretePrototype(ConcretePrototype prototype)
    {
      this._name = prototype._name;
    }
    public virtual IClassicPrototype Clone()
    {
      return new ConcretePrototype(this);
    }

    public string SetName(string name)
    {
      return this._name = name;
    }

    public override string ToString()
    {
      return $"[{this.GetType().Name}] with a name \"{_name}\"";
    }
  }
}

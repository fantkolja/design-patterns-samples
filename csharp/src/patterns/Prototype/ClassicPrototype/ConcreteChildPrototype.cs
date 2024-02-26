namespace DesignPatterns.Prototype
{
  class ConcreteChildPrototype : ConcretePrototype
  {
    private int _age;
    public ConcreteChildPrototype(string name, int age) : base(name)
    {
      this._age = age;
    }

    public ConcreteChildPrototype(ConcreteChildPrototype prototype) : base(prototype)
    {
      this._age = prototype._age;
    }

    public override IClassicPrototype Clone()
    {
      return new ConcreteChildPrototype(this);
    }

    public int SetAge(int age)
    {
      return this._age = age;
    }

    public override string ToString()
    {
      return $"{base.ToString()} and the age {this._age}";
    }
  }
}
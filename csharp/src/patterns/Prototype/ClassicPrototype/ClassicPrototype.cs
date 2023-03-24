namespace DesignPatterns.Prototype
{
  interface IClassicPrototype
  {
    IClassicPrototype Clone();
  }

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
      return $"[ConcretePrototype] with a name {_name}";
    }
  }

  class SubclassPrototype : ConcretePrototype
  {
    private int _age;
    public SubclassPrototype(string name, int age) : base(name)
    {
      this._age = age;
    }

    public SubclassPrototype(SubclassPrototype prototype) : base(prototype)
    {
      this._age = this._age = prototype._age;
    }

    public override IClassicPrototype Clone()
    {
      return new SubclassPrototype(this);
    }

    public override string ToString()
    {
      return $"{base.ToString()} and the age {this._age}";
    }
  }
}

















// ConcretePrototype original = new("original");
// ConcretePrototype copy = (ConcretePrototype) original.Clone();

// SubclassPrototype originalSub = new("originalSub", 23);
// SubclassPrototype copySub = (SubclassPrototype) originalSub.Clone();

// copy.SetName("copy");
// copySub.SetName("copySub");

// Console.WriteLine(original);
// Console.WriteLine(copy);

// Console.WriteLine(originalSub);
// Console.WriteLine(copySub);

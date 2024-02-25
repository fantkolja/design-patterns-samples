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
      return $"[{this.GetType().Name}] with a name \"{_name}\"";
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
      this._age = prototype._age;
    }

    public override IClassicPrototype Clone()
    {
      return new SubclassPrototype(this);
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

// using DesignPatterns.Prototype;

// IClassicPrototype original = new ConcretePrototype("original");
// var copy = (ConcretePrototype) original.Clone();

// IClassicPrototype originalSub = new SubclassPrototype("originalSub", 23);
// var copySub = (SubclassPrototype) originalSub.Clone();

// copy.SetName("copy");
// copySub.SetName("copySub");
// copySub.SetAge(21);

// Console.WriteLine(original);
// Console.WriteLine(copy);
// Console.WriteLine();

// Console.WriteLine(originalSub);
// Console.WriteLine(copySub);
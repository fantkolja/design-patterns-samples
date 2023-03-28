namespace DesignPatterns.Composite
{
  class MarvelHero
  {
    private List<Artefact> _artefacts = new List<Artefact>();
    public string Name { get; private set; }

    private int _power;

    public MarvelHero(string name, int power)
    {
      this.Name = name;
      this._power = power;
    }

    public void AddArtefact(Artefact artefact)
    {
      this._artefacts.Add(artefact);
    }

    public void RemoveArtefact(Artefact artefact)
    {
      this._artefacts.Remove(artefact);
    }

    public void Strike()
    {
      int totalPower = this._artefacts.Aggregate(this._power, (sum, next) => sum += next.GetPowerBuf());
      Console.WriteLine($"{this.Name} hits with power {totalPower}");
    }

    public void CalculateArtefactsWeight()
    {
      int totalArtefactsWeight = this._artefacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
      Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
    }

    public void CountArtefacts()
    {
      int totalArtefactCount = this._artefacts.Count;
      Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
    }
  }
}



// using DesignPatterns.Composite;

// var hero = new MarvelHero("BlackWidow", 1);
// var ring = new Artefact("PowerRing", 5, 50);
// var necklace = new Artefact("PerlNecklace", 10, 100);

// hero.AddArtefact(ring);
// hero.AddArtefact(necklace);

// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

// hero.RemoveArtefact(ring);
// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();



// Change request: support "nested" artefacts like GloveOfPower, Husband wearing GloveOfPower


























// Version 1: without Hero refactoring
// namespace DesignPatterns.Composite
// {
//   class MarvelHero
//   {
//     private List<Artefact> _artefacts = new List<Artefact>();
//     public string Name { get; private set; }

//     private int _power;

//     public MarvelHero(string name, int power)
//     {
//       this.Name = name;
//       this._power = power;
//     }

//     public void AddArtefact(Artefact artefact)
//     {
//       this._artefacts.Add(artefact);
//     }

//     public void RemoveArtefact(Artefact artefact)
//     {
//       this._artefacts.Remove(artefact);
//     }

//     public void Strike()
//     {
//       int totalPower = this._artefacts.Aggregate(this._power, (sum, next) => sum += next.GetPowerBuf());
//       Console.WriteLine($"{this.Name} hits with power {totalPower}");
//     }

//     public void CalculateArtefactsWeight()
//     {
//       int totalArtefactsWeight = this._artefacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
//       Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
//     }

//     public void CountArtefacts()
//     {
//       int totalArtefactCount = this._artefacts.Count;
//       Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
//     }
//   }
// }
// using DesignPatterns.Composite;

// var hero = new MarvelHero("BlackWidow", 1);
// var ring = new Artefact("PowerRing", 5, 50);
// var necklace = new Artefact("PerlNecklace", 10, 100);
// var husband = new CompositeArtefact("Thanos", 1000, 1000);

// husband.AddArtefact(ring);
// husband.AddArtefact(necklace);

// hero.AddArtefact(husband);


// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

// husband.RemoveArtefact(ring);
// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();














// Version 2: with Hero refactoring
// namespace DesignPatterns.Composite
// {
//   class MarvelHero
//   {
//     private CompositeArtefact _artefacts = new CompositeArtefact("Hero's possession", 0, 0);
//     public string Name { get; private set; }

//     private int _power;

//     public MarvelHero(string name, int power)
//     {
//       this.Name = name;
//       this._power = power;
//     }

//     public void AddArtefact(Artefact artefact)
//     {
//       this._artefacts.AddArtefact(artefact);
//     }

//     public void RemoveArtefact(Artefact artefact)
//     {
//       this._artefacts.RemoveArtefact(artefact);
//     }

//     public void Strike()
//     {
//       int totalPower = this._power + this._artefacts.GetPowerBuf();
//       Console.WriteLine($"{this.Name} hits with power {totalPower}");
//     }

//     public void CalculateArtefactsWeight()
//     {
//       int totalArtefactsWeight = this._artefacts.GetPowerBuf();
//       Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
//     }

//     public void CountArtefacts()
//     {
//       int totalArtefactCount = this._artefacts.GetCount();
//       Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
//     }
//   }
// }





// using DesignPatterns.Composite;

// var hero = new MarvelHero("BlackWidow", 1);
// var ring = new Artefact("PowerRing", 5, 50);
// var necklace = new Artefact("PerlNecklace", 10, 100);
// var husband = new CompositeArtefact("Thanos", 1000, 1000);

// husband.AddArtefact(ring);
// husband.AddArtefact(necklace);

// hero.AddArtefact(husband);


// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

// husband.RemoveArtefact(ring);
// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

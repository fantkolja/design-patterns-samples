namespace DesignPatterns.Composite
{
  class Hero
  {
    private List<Artefact> _artefacts = new List<Artefact>();
    public string Name { get; private set; }

    private int _power;

    public Hero(string name, int power)
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

// var hero = new Hero("BlackWidow", 1);
// var ring = new Artefact("PowerRing", 5, 50);
// var necklace = new Artefact("PerlNecklace", 10, 100);

// hero.AddArtefact(ring);
// hero.AddArtefact(necklace);

// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

// Console.WriteLine();

// hero.RemoveArtefact(ring);
// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();



// Change request: support "nested" artefacts like GloveOfPower, Husband wearing GloveOfPower


























// Version 1: without Hero refactoring
// namespace DesignPatterns.Composite
// {
//   class Hero
//   {
//     private List<Artefact> _artefacts = new List<Artefact>();
//     public string Name { get; private set; }

//     private int _power;

//     public Hero(string name, int power)
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

// var hero = new Hero("BlackWidow", 1);
// var ring = new Artefact("PowerRing", 5, 50);
// var necklace = new Artefact("PerlNecklace", 10, 100);

// var gloveOfPower = new ArtefactWithArtefacts("Glove Of Power", 500, 1000);
// var mindGem = new Artefact("Mind Gem", 50, 500);
// var powerGem = new Artefact("Power Gem", 10, 100);
// var soulGem = new Artefact("Soul Gem", 10, 100);

// gloveOfPower.AddArtefact(mindGem);
// gloveOfPower.AddArtefact(powerGem);
// gloveOfPower.AddArtefact(soulGem);

// hero.AddArtefact(ring);
// hero.AddArtefact(necklace);
// hero.AddArtefact(gloveOfPower);

// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

// Console.WriteLine();

// hero.RemoveArtefact(ring);
// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();














// Version 2: with Hero refactoring
// namespace DesignPatterns.Composite
// {
//   class Hero
//   {
//     private ArtefactContainer _artefacts = new ArtefactContainer("Hero's artefacts");
//     public string Name { get; private set; }

//     private int _power;

//     public Hero(string name, int power)
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
//       int totalArtefactsWeight = this._artefacts.GetWeight();
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

// var hero = new Hero("BlackWidow", 1);
// var ring = new Artefact("PowerRing", 5, 50);
// var necklace = new Artefact("PerlNecklace", 10, 100);

// var gloveOfPower = new ArtefactWithArtefacts("Glove Of Power", 500, 1000);
// var mindGem = new Artefact("Mind Gem", 50, 500);
// var powerGem = new Artefact("Power Gem", 10, 100);
// var soulGem = new Artefact("Soul Gem", 10, 100);

// gloveOfPower.AddArtefact(mindGem);
// gloveOfPower.AddArtefact(powerGem);
// gloveOfPower.AddArtefact(soulGem);

// hero.AddArtefact(ring);
// hero.AddArtefact(necklace);
// hero.AddArtefact(gloveOfPower);

// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();

// Console.WriteLine();

// hero.RemoveArtefact(ring);
// hero.CountArtefacts();
// hero.CalculateArtefactsWeight();
// hero.Strike();


// BONUS: we can work with parts of tree
// using DesignPatterns.Composite;

// var gloveOfPower = new ArtefactWithArtefacts("Glove Of Power", 500, 1000);
// var mindGem = new Artefact("Mind Gem", 50, 500);
// var powerGem = new Artefact("Power Gem", 10, 100);
// var soulGem = new Artefact("Soul Gem", 10, 100);

// gloveOfPower.AddArtefact(mindGem);
// gloveOfPower.AddArtefact(powerGem);
// gloveOfPower.AddArtefact(soulGem);

// Console.WriteLine(gloveOfPower.GetWeight());
// Console.WriteLine(gloveOfPower.GetCount());

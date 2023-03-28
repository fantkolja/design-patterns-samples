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
  }
}































// Version 1: with single GetCount()
// namespace DesignPatterns.Composite
// {
//   class CompositeArtefact : Artefact
//   {
//     private List<Artefact> _nestedArtefacts = new List<Artefact>();
//     public CompositeArtefact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
//     {
//     }

//     public override int GetPowerBuf()
//     {
//       return this._nestedArtefacts.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
//     }

//     public override int GetWeight()
//     {
//       return this._nestedArtefacts.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
//     }

//     public void AddArtefact(Artefact artefact)
//     {
//       this._nestedArtefacts.Add(artefact);
//     }

//     public void RemoveArtefact(Artefact artefact)
//     {
//       this._nestedArtefacts.Remove(artefact);
//     }

//     public int GetCount()
//     {
//       return this._nestedArtefacts.Aggregate(0, (sum, next) =>
//       {
//         int nextCount = 1;
//         if (next is CompositeArtefact)
//         {
//           CompositeArtefact nextComposite = (CompositeArtefact)next;
//           nextCount = nextComposite.GetCount();
//         }
//         return sum += nextCount;
//       });
//     }
//   }
// }

















// Version 2: with top-most GetCount()
// namespace DesignPatterns.Composite
// {
//   class CompositeArtefact : Artefact
//   {
//     private List<Artefact> _nestedArtefacts = new List<Artefact>();
//     public CompositeArtefact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
//     {
//     }

//     public override int GetPowerBuf()
//     {
//       return this._nestedArtefacts.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
//     }

//     public override int GetWeight()
//     {
//       return this._nestedArtefacts.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
//     }

//     public void AddArtefact(Artefact artefact)
//     {
//       this._nestedArtefacts.Add(artefact);
//     }

//     public void RemoveArtefact(Artefact artefact)
//     {
//       this._nestedArtefacts.Remove(artefact);
//     }

//     public override int GetCount()
//     {
//       return this._nestedArtefacts.Aggregate(1, (sum, next) => sum += next.GetCount());
//     }
//   }
// }

// Possible solutions with Count problem:
// - IsCountable flag
// - Two different classes: ArtefactContainer, CompositeArtefact
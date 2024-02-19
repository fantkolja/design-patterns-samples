namespace DesignPatterns.FactoryMethod
{
  class ArtefactCreator
  {
    public IArtefact CreateArtefact(HeroType heroType)
    {
      switch(heroType)
      {
        case HeroType.Warrior:
          return new Sword();
        case HeroType.Paladin:
          return new Gloves();
        case HeroType.Mage:
          return new Ring();
        default:
          throw new NotImplementedException($"Unknown hero type {heroType}");
      }
    }
  }
}

// new request randomly distribute artefacts




















// RandomArtefactCreator

// namespace DesignPatterns.FactoryMethod
// {
//   interface IArtefactCreator
//   {
//     public IArtefact CreateArtefact(HeroType heroType);
//   }
//   class TargetedArtefactCreator : IArtefactCreator
//   {
//     public IArtefact CreateArtefact(HeroType heroType)
//     {
//       switch(heroType)
//       {
//         case HeroType.Warrior:
//           return new Sword();
//         case HeroType.Paladin:
//           return new Gloves();
//         case HeroType.Mage:
//           return new Ring();
//         default:
//           throw new NotImplementedException($"Unknown hero type {heroType}");
//       }
//     }
//   }

//   class RandomArtefactCreator : IArtefactCreator
//   {
//     private ArtefactType _getRandomArtefactType()
//     {
//       Random random = new();
//       ArtefactType[] values = new ArtefactType[] { ArtefactType.Sword, ArtefactType.Gloves, ArtefactType.Ring };
//       int index = random.Next(values.Length);
//       return values[index];
//     }

//     private IArtefact _createRandomArtefact()
//     {
//       ArtefactType type = this._getRandomArtefactType();

//       switch(type)
//       {
//         case ArtefactType.Sword:
//           return new Sword();
//         case ArtefactType.Gloves:
//           return new Gloves();
//         case ArtefactType.Ring:
//           return new Ring();
//         default:
//           throw new NotImplementedException($"Unknown artefact type {type}");
//       }
//     }

//     public IArtefact CreateArtefact(HeroType heroType)
//     {
//       return this._createRandomArtefact();
//     }
//   }
// }



// @TODO: add samples with hierarchies: CartesianPoint => CartesianPointCreator
// ********************
// VERSION 1: Shallow copy

// namespace DesignPatterns.Prototype
// {
//   class Person : ICloneable
//   {
//     public string[] Names;
//     public IDCard IDCard;

//     public Person(string[] names, IDCard idCard)
//     {
//       this.Names = names;
//       this.IDCard = idCard;
//     }

//     public Person(Person prototype)
//     {
//       this.Names = prototype.Names;
//       this.IDCard = prototype.IDCard;
//     }

//     public object Clone()
//     {
//       return new Person(this);
//     }

//     public override string ToString()
//     {
//       return $"Names: {String.Join(",", Names)};\nID: {this.IDCard.ID};\n Photo: {this.IDCard.Photo.Url}";
//     }
//   }
// }


namespace DesignPatterns.Prototype
{
  class Person : ICloneable
  {
    public string[] Names;
    public IDCard IDCard;

    public Person(string[] names, IDCard idCard)
    {
      this.Names = names;
      this.IDCard = idCard;
    }

    public object Clone()
    {
      Person other = (Person) this.MemberwiseClone();
      other.Names = (string[]) this.Names.Clone();
      other.IDCard = (IDCard) this.IDCard.Clone();
      return other;
    }

    public override string ToString()
    {
      return $"Names: {String.Join(",", Names)};\nID: {this.IDCard.ID};\n Photo: {this.IDCard.Photo.Url}";
    }
  }
}
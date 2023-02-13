
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


using System.Xml.Serialization;

namespace DesignPatterns.Prototype
{
  public class Person : ICloneable
  {
    public string[] Names;
    public IDCard IDCard;

    public Person() {}
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



// var photo = new Photo("photo-of-vasya.jpg");
// var idCard = new IDCard(photo);
// var vasya = new Person(new[] { "Vasyl", "Petrovych", "Petrenko" }, idCard);

// var kolya = (Person) vasya.DeepClone();
// // kolya.Names = new[] { "Mykola", "Mykolajovych", "Mykolenko" };
// kolya.Names.SetValue("Mykola", 0);
// kolya.Names.SetValue("Mykolajovych", 1);
// kolya.Names.SetValue("Mykolenko", 2);
// kolya.IDCard.ID = Guid.NewGuid();
// kolya.IDCard.Photo.Url = "photo-of-kolya.jpg";

// Console.WriteLine(vasya);
// Console.WriteLine(kolya);
// ********************
// VERSION 1: Bare class

namespace DesignPatterns.Prototype
{
  class Person : IClassicPrototype
  {
    public string[] Names { get; private set; }
    public IDCard IDCard { get; private set; }

    public Person(string[] names, IDCard idCard)
    {
      this.Names = names;
      this.IDCard = idCard;
    }

    public Person(Person prototype)
    {
      this.Names = prototype.Names;
      this.IDCard = prototype.IDCard;
    }

    public override string ToString()
    {
      return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}\n";
    }

    public IClassicPrototype Clone()
    {
      return new Person(this);
    }
  }
}

// New Requirement: add possibility to clone the Person

// using DesignPatterns.Prototype;

// var photo = new Photo("https://cool-photo");
// var idCard = new IDCard(photo);
// var mykola = new Person(new[] { "Mykola", "Fant" }, idCard);

// Console.WriteLine(mykola);

// var clonoKolya = (Person) mykola.Clone();
// clonoKolya.Names[0] = "Kolya";

// Console.WriteLine(clonoKolya);

// // The copy is shallow
// Console.WriteLine(mykola);















// ********************
// VERSION 2: Shallow copy with custom IClassicPrototype

// namespace DesignPatterns.Prototype
// {
//   class Person : IClassicPrototype
//   {
//     public string[] Names { get; private set; }
//     public IDCard IDCard { get; private set; }

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

//     public override string ToString()
//     {
//       return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}\n";
//     }

//     public IClassicPrototype Clone()
//     {
//       return new Person(this);
//     }
//   }
// }


// New Requirement
// Rewrite using C# built-in possibilities


















// ********************
// VERSION 3: Shallow copy with built-in ICloneable, MemberwiseClone

// namespace DesignPatterns.Prototype
// {
//   class Person : ICloneable
//   {
//     public string[] Names { get; private set; }
//     public IDCard IDCard { get; private set; }

//     public Person(string[] names, IDCard idCard)
//     {
//       this.Names = names;
//       this.IDCard = idCard;
//     }

//     public override string ToString()
//     {
//       return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}\n";
//     }

//     public object Clone()
//     {
//       return this.MemberwiseClone();
//     }
//   }
// }




// Version 4: Deep step-wise clone
// namespace DesignPatterns.Prototype
// {
//   class Person : ICloneable
//   {
//     public string[] Names { get; private set; }
//     public IDCard IDCard { get; private set; }

//     public Person(string[] names, IDCard idCard)
//     {
//       this.Names = names;
//       this.IDCard = idCard;
//     }

//     public override string ToString()
//     {
//       return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}\n";
//     }

//     public object Clone()
//     {
//       Person other = (Person) this.MemberwiseClone();
//       other.IDCard = (IDCard) this.IDCard.Clone();
//       other.Names = (string[]) this.Names.Clone();
//       return other;
//     }
//   }
// }
 

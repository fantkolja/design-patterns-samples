// ********************
// VERSION 1: Bare class

namespace DesignPatterns.Prototype
{
  class Person
  {
    public string[] Names { get; private set; }
    public IDCard IDCard { get; private set; }

    public Person(string[] names, IDCard idCard)
    {
      this.Names = names;
      this.IDCard = idCard;
    }

    public override string ToString()
    {
      return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}";
    }
  }
}

// New Requirement: add possibility to clone the Person

// using DesignPatterns.Prototype;

// var photo = new Photo("https://sdcsdc");
// var idCard = new IDCard(photo);
// var mykola = new Person(new[] { "Mykola", "Fant" }, idCard);

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

//     private Person(Person prototype)
//     {
//       this.Names = prototype.Names;
//       this.IDCard = prototype.IDCard;
//     }

//     public IClassicPrototype Clone()
//     {
//       return new Person(this);
//     }

//     public override string ToString()
//     {
//       return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}";
//     }
//   }
// }





















// ********************
// VERSION 3: Shallow copy with built-in ICloneable

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

//     private Person(Person prototype)
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
//       return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}";
//     }
//   }
// }











// ********************
// VERSION 4: Shallow copy with built-in MemberwiseClone

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

//     public object Clone()
//     {
//       return this.MemberwiseClone();
//     }

//     public override string ToString()
//     {
//       return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}";
//     }
//   }
// }






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
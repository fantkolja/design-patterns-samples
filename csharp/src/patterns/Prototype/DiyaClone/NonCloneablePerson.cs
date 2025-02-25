namespace DesignPatterns.Prototype
{
  class NonCloneablePerson
  {
    public string[] Names { get; private set; }
    public IDCard IDCard { get; private set; }

    public NonCloneablePerson(string[] names, IDCard idCard)
    {
      this.Names = names;
      this.IDCard = idCard;
    }

    public override string ToString()
    {
      return $"Names: {String.Join(", ", Names)};\nID: {this.IDCard.ID};\nPhoto: {this.IDCard.Photo.Url}\n";
    }
  }
}


// using DesignPatterns.Prototype;

// var photo = new Photo("url");
// var idCard = new IDCard(photo);
// var mykola1 = new NonCloneablePerson(new string [] {"mykola", "fant"}, idCard);
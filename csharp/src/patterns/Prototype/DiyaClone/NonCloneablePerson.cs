namespace DesignPatterns.Prototype
{
  class NonCloneablePerson
  {
    private int _age;
    private string Sex { get; set; }
    public string[] Names { get; private set; }
    public IDCard IDCard { get; private set; }

    public NonCloneablePerson(int age, string sex, string[] names, IDCard idCard)
    {
      this._age = age;
      this.Sex = sex;
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
// var mykola1 = new NonCloneablePerson(23, "male", new string [] {"mykola", "fant"}, idCard);
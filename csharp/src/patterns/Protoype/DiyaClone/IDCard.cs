namespace DesignPatterns.Prototype
{
  class IDCard : ICloneable
  {
    public Guid ID { get; set; }
    public Photo Photo { get; set; }

    public IDCard(Photo photo)
    {
      this.ID = Guid.NewGuid();
      this.Photo = photo;
    }

    public object Clone()
    {
      IDCard other = (IDCard) this.MemberwiseClone();
      other.Photo = (Photo) this.Photo.Clone();
      return other;
    }
  }
}
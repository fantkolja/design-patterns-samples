namespace DesignPatterns.Prototype
{
  public class IDCard : ICloneable
  {
    public Guid ID { get; set; }
    public Photo Photo { get; set; }

    private IDCard() {}
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
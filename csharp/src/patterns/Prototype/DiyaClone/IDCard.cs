namespace DesignPatterns.Prototype
{
  public class IDCard
  {
    public Guid ID { get; private set; }
    public Photo Photo { get; private set; }
    public IDCard(Photo photo)
    {
      this.ID = Guid.NewGuid();
      this.Photo = photo;
    }
  }
}

















// Version 2:
// namespace DesignPatterns.Prototype
// {
//   public class IDCard : IPrototype<IDCard>
//   {
//     public Guid ID { get; private set; }
//     public Photo Photo { get; private set; }
//     public IDCard(Photo photo)
//     {
//       this.ID = Guid.NewGuid();
//       this.Photo = photo;
//     }

//     public IDCard DeepClone()
//     {
//       IDCard other = (IDCard) this.MemberwiseClone();
//       other.Photo = (Photo) this.Photo.DeepClone();
//       return other;
//     }
//   }
// }
namespace DesignPatterns.Prototype
{
  public class Photo
  {
    public string Url { get; private set; }

    public Photo(string url)
    {
      this.Url = url;
    }
  }
}















// Version 2

// namespace DesignPatterns.Prototype
// {
//   public class Photo : ICloneable
//   {
//     public string Url { get; private set; }

//     public Photo(string url)
//     {
//       this.Url = url;
//     }

//     public object Clone()
//     {
//       return this.MemberwiseClone();
//     }
//   }
// }
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
//   public class Photo : IPrototype<Photo>
//   {
//     public string Url { get; private set; }

//     public Photo(string url)
//     {
//       this.Url = url;
//     }

//     public Photo DeepClone()
//     {
//       return this.MemberwiseClone();
//     }
//   }
// }
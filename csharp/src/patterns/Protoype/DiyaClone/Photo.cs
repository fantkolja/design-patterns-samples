namespace DesignPatterns.Prototype
{
  public class Photo : ICloneable
  {
    public string Url { get; set; }

    private Photo() {}
    public Photo(string url)
    {
      this.Url = url;
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}
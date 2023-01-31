namespace DesignPatterns.Prototype
{
  class Photo : ICloneable
  {
    public string Url { get; set; }

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
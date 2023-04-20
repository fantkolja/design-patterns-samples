namespace DesignPatterns.Iterator
{
  class Letter
  {
    public char Content { get; set; }
    public Dictionary<Letter, bool> Links = new Dictionary<Letter, bool>();
    public Letter(char content)
    {
      this.Content = content;
    }
  }
}
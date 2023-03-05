namespace DesignPatterns.Adapter
{
  class ClassicTarget
  {
    public virtual int DoSomething()
    {
      return new Random().Next();
    }
  }
}
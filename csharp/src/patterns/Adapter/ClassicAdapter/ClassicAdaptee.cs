namespace DesignPatterns.Adapter
{
  class ClassicAdaptee
  {
    public int DoSomethingInAnotherWay(int maxValue)
    {
      return new Random().Next(maxValue);
    }
  }
}
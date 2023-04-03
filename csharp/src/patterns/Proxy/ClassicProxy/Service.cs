namespace DesignPatterns.Proxy
{
  class Service : IService
  {
    public string SomeProperty => "Property";

    public void DoSomething()
    {
      Console.WriteLine("DoSomething");
    }
  }
}
namespace DesignPatterns.Proxy
{
  class Proxy : IService
  {
    private IService _originalService;

    public Proxy(IService originalService)
    {
      this._originalService = originalService;
    }
    public string SomeProperty => "Property";

    public void DoSomething()
    {
      Console.WriteLine("DoSomething");
    }
  }
}


// using DesignPatterns.Proxy;

// var originalService = new Service();
// var proxiedService = new Proxy(originalService);
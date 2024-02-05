namespace ProgrammingPrinciples.COI
{
  interface IEngine
  {
      void Start();
  }

  class CombustionEngine : IEngine
  {
      void IEngine.Start() 
      {
          Console.WriteLine("Starting the combustion engine.");
      }
  }

  class ElectricEngine : IEngine
  {
      void IEngine.Start()
      {
          Console.WriteLine("Starting the electric engine.");
      }
  }

  class CompositionCar 
  {
    private readonly IEngine _engine;

    public CompositionCar(IEngine engine)
    {
        _engine = engine;
    }

    public void Open()
    {
      Console.WriteLine($"Car is open");
    }
    
    public void Close()
    {
      Console.WriteLine($"Car is closed");
    }

    public void Start()
    {
        _engine.Start();
    }
  }
}

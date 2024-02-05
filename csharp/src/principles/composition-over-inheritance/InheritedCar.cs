namespace ProgrammingPrinciples.COI
{
  abstract class Car
  {
    public void Open()
    {
      Console.WriteLine($"Car is open");
    }
    public void Close()
    {
      Console.WriteLine($"Car is closed");
    }
    abstract public void Start();
  }

  class CombustionEngineCar : Car
  {
    public override void Start()
    {
      Console.WriteLine("Starting the combustion engine.");
    }
  }

  class ElectricCar : Car
  {
    public override void Start()
    {
      Console.WriteLine("Starting the electric engine.");
    }
  }
}
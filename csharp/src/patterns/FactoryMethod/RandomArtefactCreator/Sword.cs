namespace DesignPatterns.FactoryMethod
{
  class Sword : IArtefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }

    public void Use()
    {
      Console.WriteLine($"Hit with a sword");
    }
  }
}
namespace DesignPatterns.FactoryMethod
{
  class Gloves : IArtefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }
    public void Use()
    {
      Console.WriteLine("Put gloves on");
    }
  }
}
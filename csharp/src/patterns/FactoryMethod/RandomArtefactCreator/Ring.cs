namespace DesignPatterns.FactoryMethod
{
  class Ring : IArtefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }

    public void Use()
    {
      Console.WriteLine("Put ring on");
    }
  }
}
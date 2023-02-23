namespace DesignPatterns.FactoryMethod
{
  interface IArtefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }

    public void Use();
  }
}
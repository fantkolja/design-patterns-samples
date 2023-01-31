namespace DesignPatterns.FactoryMethod
{
  interface Artefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }
  }

  class Sword : Artefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }

    public int Hit(object enemy)
    {
      Console.WriteLine($"Hit {enemy} by {5} HP");
      return 5;
    }
  }

  class Gloves : Artefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }
    public bool Wear(string hero)
    {
      if (hero == "Woman")
      {
        return true;
      }

      return false;
    }
  }

  class Ring : Artefact
  {
    public double Price { get; set; }
    public double Weight { get; set; }
  }
}
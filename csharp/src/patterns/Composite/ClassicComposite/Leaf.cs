namespace DesignPatterns.Composite
{
  class Leaf : IComponent
  {
    private string _name;

    public Leaf(string name)
    {
      this._name = name;
    }
    public void Operation()
    {
      Console.WriteLine($"I am just a Leaf with the name {this._name}");
    }
  }
}
using System.Text;

namespace DesignPatterns.Builder
{
  class SimplePizza
  {
    private string _cheese = "No cheese";
    private string _meat = "No meat";
    private bool _corn = false;
    private string _olives = "No olives";
    private int? _radius = 10;
    private int? _thickness = 5;

    // +10 more

    public SimplePizza() {}

    public override string ToString()
    {
      string cornMsg = this._corn ? "corn" : "No corn";
      return new StringBuilder()
        .Append($"{this._radius}cm wide;")
        .Append($"\n{this._thickness}cm thick;")
        .Append($"\nWith:\n{this._cheese};")
        .Append($"\n{cornMsg};")
        .Append($"\n{this._olives};")
        .Append($"\n{this._meat}.")
        .ToString();
    }
  }
}







// Builder-ready Pizza

namespace DesignPatterns.Builder
{
  class Pizza
  {
    private string _cheese = "No cheese";
    private string _meat = "No meat";
    private bool _corn = false;
    private string _olives = "No olives";
    private int? _radius;
    private int? _thickness;

    // +10 more

    public Pizza() {}
    public string SetCheese(string cheese)
    {
      return this._cheese = cheese;
    }
    public string SetMeat(string meat)
    {
      return this._meat = meat;
    }
    public bool SetCorn()
    {
      return this._corn = true;
    }
    public string SetOlives(string olives)
    {
      return this._olives = olives;
    }
    public int SetRadius(int radius)
    {
      this._radius = radius;
      return radius;
    }
    public int SetThickness(int thickness)
    {
      this._thickness = thickness;
      return thickness;
    }

    public override string ToString()
    {
      string cornMsg = this._corn ? "corn" : "No corn";
      return $"{this._radius}cm wide;\n{this._thickness}cm thick.\nWith:\n{this._cheese};\n{cornMsg};\n{this._meat}.";
    }
  }
}
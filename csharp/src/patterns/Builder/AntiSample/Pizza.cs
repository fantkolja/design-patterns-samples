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


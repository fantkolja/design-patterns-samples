namespace DesignPatterns.Builder
{
  class Pizza
  {
    private string? _mashrooms;
    private string? _cheese;
    private string? _meat;
    private bool? _corn;
    private bool? _pepper;
    private string? _olives;
    private int? _radius;
    private int? _thickness;

    // +10 more

    public Pizza(
      string? _mashrooms,
      string? _cheese,
      string? _meat,
      bool? _corn,
      bool? _pepper,
      string? _olives,
      int? _radius,
      int? _thickness
    )
    {
      this._mashrooms = _mashrooms;
      this._cheese = _cheese;
      this._meat = _meat;
      this._corn = _corn;
      this._pepper = _pepper;
      this._olives = _olives;
      this._radius = _radius;
      this._thickness = _thickness;
      // + more

    }
        // Pizza pz = new Pizza(
        //   "champignon",
        //   "mascarpone",
        //   "chicken",
        //   null,
        //   null,
        //   null,
        //   32,
        //   2
        // );
  }
}


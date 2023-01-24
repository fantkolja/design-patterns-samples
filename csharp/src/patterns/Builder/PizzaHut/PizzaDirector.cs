namespace DesignPatterns.Builder
{
  class PizzaDirector
  {
    private PizzaBuilder _builder;

    public PizzaDirector SetBuilder(PizzaBuilder builder)
    {
      this._builder = builder;
      return this;
    }

    public PizzaDirector(PizzaBuilder builder)
    {
      this._builder = builder;
    }

    public Pizza GetNeapolitanaPizza()
    {
      return this._builder
        .SetRadius(45)
        .AddCheese("Mascarpone")
        .AddCorn()
        .AddMeat("Chicken")
        .GetPizza();
    } 

    public Pizza GetDrivePizza()
    {
      return this._builder
        .SetRadius(50)
        .AddCheese("Bree")
        .AddCorn()
        .AddOlives("Green")
        .GetPizza();
    } 
  }
}
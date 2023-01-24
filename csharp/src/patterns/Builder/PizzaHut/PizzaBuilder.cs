namespace DesignPatterns.Builder
{
  interface PizzaBuilder
  {
    Pizza GetPizza();
    PizzaBuilder SetRadius(int radius);
    PizzaBuilder AddCheese(string cheese);
    PizzaBuilder AddMeat(string meat);
    PizzaBuilder AddCorn();
    PizzaBuilder AddOlives(string olives);

  }

  class HousePizzaBuilder : PizzaBuilder
  {
    private Pizza _pizza = new Pizza();
    private void _reset()
    {
      this._pizza = new Pizza();
      this._pizza.SetThickness(5);
    }

    public HousePizzaBuilder()
    {
      this._reset();
    }

    public PizzaBuilder AddCheese(string cheese)
    {
      this._pizza.SetCheese(cheese);
      return this;
    }

    public PizzaBuilder AddCorn()
    {
      this._pizza.SetCorn();
      return this;
    }

    public PizzaBuilder AddMeat(string meat)
    {
      this._pizza.SetMeat(meat);
      return this;
    }

    public PizzaBuilder AddOlives(string olives)
    {
      this._pizza.SetOlives(olives);
      return this;
    }

    public Pizza GetPizza()
    {
      Pizza pizza = this._pizza;
      this._reset();
      return pizza;
    }

    public PizzaBuilder SetRadius(int radius)
    {
      this._pizza.SetRadius(radius);
      return this;
    }
  }
}
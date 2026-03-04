namespace DesignPatterns.Builder
{
  interface IPizzaBuilder
  {
    Pizza GetPizza();
    IPizzaBuilder SetRadius(int radius);
    IPizzaBuilder AddCheese(string cheese);
    IPizzaBuilder AddMeat(string meat);
    IPizzaBuilder AddCorn();
    IPizzaBuilder AddOlives(string olives);

  }

  class HousePizzaBuilder : IPizzaBuilder
  {
    private Pizza _pizza;

    private Pizza _createDefaultPizza()
    {
      Pizza pizza = new Pizza();
      pizza.SetThickness(5);
      return pizza;
    }
    private void _reset()
    {
      this._pizza = this._createDefaultPizza();
    }

    public HousePizzaBuilder()
    {
      this._pizza = this._createDefaultPizza();
    }

    public IPizzaBuilder AddCheese(string cheese)
    {
      this._pizza.SetCheese(cheese);
      return this;
    }

    public IPizzaBuilder AddCorn()
    {
      this._pizza.SetCorn();
      return this;
    }

    public IPizzaBuilder AddMeat(string meat)
    {
      this._pizza.SetMeat(meat);
      return this;
    }

    public IPizzaBuilder AddOlives(string olives)
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

    public IPizzaBuilder SetRadius(int radius)
    {
      this._pizza.SetRadius(radius);
      return this;
    }
  }
}
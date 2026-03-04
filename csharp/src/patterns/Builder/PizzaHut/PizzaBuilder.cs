namespace DesignPatterns.Builder;
abstract class PizzaBuilder
{
  protected Pizza _pizza;
  protected void _reset()
  {
    this._pizza = this._createDefaultPizza();
  }
  abstract protected Pizza _createDefaultPizza();
  public PizzaBuilder()
  {
    this._pizza = this._createDefaultPizza();
  }
  public Pizza GetPizza()
  {
    Pizza pizza = this._pizza;
    this._reset();
    return pizza;
  }
  abstract public PizzaBuilder SetRadius(int radius);
  abstract public PizzaBuilder AddCheese(string cheese);
  abstract public PizzaBuilder AddMeat(string meat);
  abstract public PizzaBuilder AddCorn();
  abstract public PizzaBuilder AddOlives(string olives);

}

class HousePizzaBuilder : PizzaBuilder
{
  protected override Pizza _createDefaultPizza()
  {
    Pizza pizza = new Pizza();
    pizza.SetThickness(5);
    return pizza;
  }

  public override PizzaBuilder AddCheese(string cheese)
  {
    this._pizza.SetCheese(cheese);
    return this;
  }

  public override PizzaBuilder AddCorn()
  {
    this._pizza.SetCorn();
    return this;
  }

  public override PizzaBuilder AddMeat(string meat)
  {
    this._pizza.SetMeat(meat);
    return this;
  }

  public override PizzaBuilder AddOlives(string olives)
  {
    this._pizza.SetOlives(olives);
    return this;
  }

  public override PizzaBuilder SetRadius(int radius)
  {
    this._pizza.SetRadius(radius);
    return this;
  }
}





class NewYorkPizzaBuilder : PizzaBuilder
{
  protected override Pizza _createDefaultPizza()
  {
    Pizza pizza = new Pizza();
    pizza.SetThickness(5);
    return pizza;
  }

  public override PizzaBuilder AddCheese(string cheese)
  {
    this._pizza.SetCheese(cheese);
    return this;
  }

  public override PizzaBuilder AddCorn()
  {
    this._pizza.SetCorn();
    return this;
  }

  public override PizzaBuilder AddMeat(string meat)
  {
    this._pizza.SetMeat(meat);
    return this;
  }

  public override PizzaBuilder AddOlives(string olives)
  {
    this._pizza.SetOlives(olives);
    return this;
  }

  public override PizzaBuilder SetRadius(int radius)
  {
    this._pizza.SetRadius(radius);
    return this;
  }
}





// using DesignPatterns.Builder;

// var builder = new HousePizzaBuilder();
// var director = new PizzaDirector(builder);
// var pizza = director.GetNeapolitanaPizza();

// director.SetBuilder(new NewYorkPizzaBuilder());
// var newYorkPizza = director.GetDrivePizza();
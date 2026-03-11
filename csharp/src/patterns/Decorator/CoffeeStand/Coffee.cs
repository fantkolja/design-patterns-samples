namespace DesignPatterns.Decorator;

abstract class Coffee
{
  public abstract int Amount { get; }
  public abstract int Price { get; }

  public abstract double CaloriesPerUnit { get; }

  public virtual double GetCalories()
  {
    return Amount * CaloriesPerUnit;
  }
}

class Americano : Coffee
{
    public override int Amount => 100;
    public override int Price => 25;

    public override double CaloriesPerUnit => 0.01;
}

class Espresso : Coffee
{
  public override int Amount => 50;
  public override int Price => 20;

  public override double CaloriesPerUnit => 0.03;
}


// Feature Request: add Coffee with Milk, DoubleAmount, Sugar


// Possible approaches: 
//
//  - via existing class change (similiar to Builder, but
//                               1. There are no predefined products
//                               2. You can add sugar AFTER object creation)
//  - via inheritance
// 
  // class AmericanoWithMilk : Americano
  // {
  //   public AmericanoWithMilk(int amount, int price) : base(amount, price)
  //   {
  //   }

  //   public override double GetCalories()
  //   {
  //     return base.GetCalories() * 100;
  //   }
  // }


































abstract class CoffeeExtra : Coffee
{
  protected Coffee _coffee;

  protected CoffeeExtra(Coffee coffee)
  {
    _coffee = coffee;
  }

  public override int Amount => _coffee.Amount;
  public override int Price => _coffee.Price;

  public override double CaloriesPerUnit => _coffee.CaloriesPerUnit;
}

class WithMilk : CoffeeExtra
{
  public WithMilk(Coffee coffee) : base(coffee) {}

  public override int Amount => base.Amount + 3;
  public override int Price => base.Price + 5;

  public override double CaloriesPerUnit => base.CaloriesPerUnit + 0.02;
}

class Doubled : CoffeeExtra
{
  public Doubled(Coffee coffee) : base(coffee) {}

  public override int Amount => base.Amount * 2;
  public override int Price => base.Price + 10;
}

class WithSugar : CoffeeExtra
{
  private int _sticksCount;

  public WithSugar(Coffee coffee, int sticksCount) : base(coffee)
  {
    _sticksCount = sticksCount;
  }

  public override int Amount => base.Amount + _sticksCount;

  public override int Price => base.Price;

  public override double GetCalories()
  {
    return base.GetCalories() + _sticksCount * 100;
  }
}

// using DesignPatterns.Decorator;

// Coffee order = new Doubled(new WithMilk(new Espresso()));

// Coffee order2 = new WithSugar(new Americano(), 2);
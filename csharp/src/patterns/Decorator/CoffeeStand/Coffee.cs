namespace DesignPatterns.Decorator
{
  abstract class Coffee
  {
    public virtual int Amount { get; set; }
    public virtual int Price { get; set; }
    abstract public double GetCalories();
  }

  class Americano : Coffee
  {
    public Americano() : base()
    {
      this.Amount = 100;
      this.Price = 25;
    }

    public override double GetCalories()
    {
      return this.Amount * 0.01;
    }
  }

  class Espresso : Coffee
  {
    public Espresso() : base()
    {
      this.Amount = 50;
      this.Price = 20;
    }

    public override double GetCalories()
    {
      return this.Amount * 0.03;
    }
  }
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


































  namespace DesignPatterns.Decorator
  {
    abstract class CoffeeExtra : Coffee
    {
      private Coffee _coffee;
      public override int Amount
      {
        get { return this._coffee.Amount; }
        set { this._coffee.Amount = value; }
      }
      public override int Price
      {
        get { return this._coffee.Price; }
        set { this._coffee.Price = value; }
      }
      public CoffeeExtra(Coffee coffee) : base()
      {
        this._coffee = coffee;
      }

      public override double GetCalories()
      {
        return this._coffee.GetCalories();
      }
    }

  class WithMilk : CoffeeExtra
  {
    public WithMilk(Coffee coffee) : base(coffee)
    {
      base.Amount += 3;
      base.Price += 5;
    }

    public override double GetCalories()
    {
      return base.GetCalories() * 100;
    }
  }

  class Doubled : CoffeeExtra
  {
    public Doubled(Coffee coffee) : base(coffee)
    {
      base.Amount *= 2;
      base.Price += 10;
    }

    public override double GetCalories()
    {
      return base.GetCalories() * 2;
    }
  }

  class WithSugar : CoffeeExtra
  {
    private int _sticksCount;
    public WithSugar(Coffee coffee, int sticksCount) : base(coffee)
    {
      this._sticksCount = sticksCount;
      base.Amount += sticksCount * 1;
    }

    public override double GetCalories()
    {
      return base.GetCalories() + this._sticksCount * 100;
    }
  }
}

// using DesignPatterns.Decorator;

// Coffee order = new Doubled(new WithMilk(new Espresso()));

// Coffee order2 = new WithSugar(new Americano(), 2);
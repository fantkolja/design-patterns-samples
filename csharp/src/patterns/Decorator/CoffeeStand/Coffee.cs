namespace DesignPatterns.Decorator
{
  abstract class Coffee
  {
    public int Amount { get; protected set; }
    public int Price { get; protected set; }
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


































//   namespace DesignPatterns.Decorator
//   {
//     abstract class BaseCoffeeExtra : Coffee
//     {
//       protected Coffee _coffee;
//       public BaseCoffeeExtra(Coffee coffee) : base()
//       {
//         this._coffee = coffee;
//       }

//       abstract public override double GetCalories();
//     }

//   class WithMilk : BaseCoffeeExtra
//   {
//     public WithMilk(Coffee coffee) : base(coffee)
//     {
//       this.Amount += 3;
//       this.Price += 5;
//     }

//     public override double GetCalories()
//     {
//       return this._coffee.GetCalories() * 100;
//     }
//   }

//   class Doubled : BaseCoffeeExtra
//   {
//     public Doubled(Coffee coffee) : base(coffee)
//     {
//       this.Amount *= 2;
//       this.Price += 10;
//     }

//     public override double GetCalories()
//     {
//       return this._coffee.GetCalories() * 2;
//     }
//   }

//   class WithSugar : BaseCoffeeExtra
//   {
//     private int _sticksCount;
//     public WithSugar(Coffee coffee, int sticksCount) : base(coffee)
//     {
//       this._sticksCount = sticksCount;
//       this.Amount += sticksCount * 1;
//     }

//     public override double GetCalories()
//     {
//       return this._coffee.GetCalories() + this._sticksCount * 100;
//     }
//   }
// }

// using DesignPatterns.Decorator;

// Coffee order = new Doubled(new WithMilk(new Espresso()));

// Coffee order2 = new WithSugar(new Americano(), 2);
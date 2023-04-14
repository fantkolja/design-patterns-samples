namespace DesignPatterns.Strategy
{
  class Context
  {
    private IStrategy _strategy = new ConcreteStrategy1();

    public void SetStrategy(IStrategy strategy)
    {
      this._strategy = strategy;
    }
    public void DoBusinessLogic(int arg)
    {
      this._strategy.Execute(arg);
    }
  }
}


// using DesignPatterns.Strategy;

// var ctx = new Context();

// var someStrategy = new ConcreteStrategy1();
// var anotherStrategy = new ConcreteStrategy2();

// ctx.SetStrategy(anotherStrategy);

// ctx.DoBusinessLogic(3);

// ctx.SetStrategy(someStrategy);

// ctx.DoBusinessLogic(3);
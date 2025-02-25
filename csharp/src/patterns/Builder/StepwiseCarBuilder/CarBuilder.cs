namespace DesignPatterns.Builder
{
  interface ICarBuilder
  {
    ICarBuilder WithEngine(string engine);
    ICarBuilder WithTransmission(string transmission);
    ICarBuilder HavingWheelSize(short size);
    ICarBuilder InColor(string color);
    Car Build();
  }

  class CarBuilder : ICarBuilder
  {
    private Car _car = new Car();

    private void _reset()
    {
      this._car = new Car();
    }
    public ICarBuilder HavingWheelSize(short size)
    {
      this._car.WheelSize = size;
      return this;
    }

    public ICarBuilder InColor(string color)
    {
      this._car.Color = color;
      return this;
    }

    public ICarBuilder WithEngine(string engine)
    {
      this._car.Engine = engine;
      return this;
    }

    public ICarBuilder WithTransmission(string transmission)
    {
      this._car.Transmission = transmission;
      return this;
    }

    public Car Build()
    {
      Car car = this._car;
      this._reset();
      return car;
    }
  }
}


// Feature request: first we should choose engine, then other features.
// using DesignPatterns.Builder;

// var builder = new CarBuilder();
// builder
//   .WithTransmission("ZF")
//   .WithEngine("1.6L");


























// namespace DesignPatterns.Builder
// {
//   #1 Program to interface
//
//   interface IEngineBuilder
//   {
//     ICarWithEngineBuilder WithEngine(string engine);
//   }

//   interface ICarWithEngineBuilder
//   {
//     ICarWithEngineBuilder WithTransmission(string transmission);
//     ICarWithEngineBuilder HavingWheelSize(short size);
//     ICarWithEngineBuilder InColor(string color);
//     Car Build();
//   }
  
//   class CarBuilder
//   {
//     #2 Element of Singleton
//
//     private CarBuilder(){}
//
//     public static IEngineBuilder Create()
//     {
//       return new Impl();
//     }
//
//     ISP
//     private class Impl : IEngineBuilder, ICarWithEngineBuilder
//     {
//       private Car _car = new Car();

//       private void _reset()
//       {
//         this._car = new Car();
//       }

//       public Impl()
//       {
//         this._reset();
//       }
//       public ICarWithEngineBuilder HavingWheelSize(short size)
//       {
//         this._car.WheelSize = size;
//         return this;
//       }

//       public ICarWithEngineBuilder InColor(string color)
//       {
//         this._car.Color = color;
//         return this;
//       }

//       public ICarWithEngineBuilder WithEngine(string engine)
//       {
//         this._car.Engine = engine;
//         return this;
//       }

//       public ICarWithEngineBuilder WithTransmission(string transmission)
//       {
//         this._car.Transmission = transmission;
//         return this;
//       }

//       public Car Build()
//       {
//         Car car = this._car;
//         this._reset();
//         return car;
//       }
//     }
//   }
// }
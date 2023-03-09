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





























// namespace DesignPatterns.Builder
// {
//   class CarBuilder
//   {
//     public static IEngineBuilder Create()
//     {
//       return new Impl();
//     }

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
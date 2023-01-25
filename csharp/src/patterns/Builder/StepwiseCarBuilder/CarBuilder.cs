namespace DesignPatterns.Builder
{
  interface ICarWithEngineBuilder
  {
    ICarWithEngineBuilder WithEngine(string engine);
    ICarWithEngineBuilder WithTransmission(string transmission);
    ICarWithEngineBuilder HavingWheelSize(short size);
    ICarWithEngineBuilder InColor(string color);
    Car Build();
  }
  interface IEngineBuilder
  {
    ICarWithEngineBuilder WithEngine(string engine);
  }


  class CarBuilder
  {
    public static IEngineBuilder Create()
    {
      return new Impl();
    }

    private class Impl : IEngineBuilder, ICarWithEngineBuilder
    {
      private Car _car = new Car();

      private void _reset()
      {
        this._car = new Car();
      }

      public Impl()
      {
        this._reset();
      }
      public ICarWithEngineBuilder HavingWheelSize(short size)
      {
        this._car.WheelSize = size;
        return this;
      }

      public ICarWithEngineBuilder InColor(string color)
      {
        this._car.Color = color;
        return this;
      }

      public ICarWithEngineBuilder WithEngine(string engine)
      {
        this._car.Engine = engine;
        return this;
      }

      public ICarWithEngineBuilder WithTransmission(string transmission)
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
}
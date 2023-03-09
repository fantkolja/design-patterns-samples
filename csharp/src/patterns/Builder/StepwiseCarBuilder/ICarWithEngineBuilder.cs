namespace DesignPatterns.Builder
{
  interface ICarWithEngineBuilder
  {
    ICarWithEngineBuilder WithTransmission(string transmission);
    ICarWithEngineBuilder HavingWheelSize(short size);
    ICarWithEngineBuilder InColor(string color);
    Car Build();
  }
}
namespace DesignPatterns.Builder
{
  interface IEngineBuilder
  {
    ICarWithEngineBuilder WithEngine(string engine);
  }
}
namespace DesignPatterns.AbstractFactory
{
  interface IVAGFactory
  {
    public ITransmission CreateTransmission();
    public IEngine CreateEngine();
  }
}
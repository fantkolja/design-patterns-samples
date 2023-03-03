namespace DesignPatterns.AbstractFactory
{
  class VWFactory : IVAGFactory
  {

    public IEngine CreateEngine()
    {
      return new VWEngine();
    }

    public ITransmission CreateTransmission()
    {
      return new VWTransmission();
    }
  }
}
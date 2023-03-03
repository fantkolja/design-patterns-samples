namespace DesignPatterns.AbstractFactory
{
  class AudiFactory : IVAGFactory
  {

    IEngine IVAGFactory.CreateEngine()
    {
      return new AudiEngine();
    }

    ITransmission IVAGFactory.CreateTransmission()
    {
      return new AudiTransmission();
    }
  }
}
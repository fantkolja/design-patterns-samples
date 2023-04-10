namespace DesignPatterns.Mediator
{
  class CommandCentre
  {
    private List<Runway> _runways = new List<Runway>();
    private List<Aircraft> _aircrafts = new List<Aircraft>();

    public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
    {
      this._runways.AddRange(runways);
      this._aircrafts.AddRange(aircrafts);
    }
  }
}
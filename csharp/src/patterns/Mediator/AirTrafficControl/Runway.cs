namespace DesignPatterns.Mediator
{
  class Runway
  {
    public readonly Guid Id = Guid.NewGuid();
    public Aircraft? IsBusyWithAircraft;

    public bool CheckIsActive()
    {
      bool result = false;
      if (this.IsBusyWithAircraft != null)
      {
        result = this.IsBusyWithAircraft.IsTakingOff;
      }
      return result;
    }
  }
}
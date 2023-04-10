namespace DesignPatterns.Mediator
{
  class  Aircraft
  {
    public string Name;
    public Runway? CurrentRunway { get; set; }
    public bool IsTakingOff { get; set; }
    public Aircraft(string name, int size)
    {
      this.Name = name;
    }
    public void Land(Runway runway)
    {
      Console.WriteLine($"Aircraft {this.Name} is landing.");
      Console.WriteLine($"Checking runway.");
      if (runway.IsBusyWithAircraft == null)
      {
        Console.WriteLine($"Aircraft {this.Name} has landed.");
        runway.IsBusyWithAircraft = this;
        runway.HighLightRed();
        this.CurrentRunway = runway;
      }
      else
      {
        Console.WriteLine($"Could not land, the runway is busy.");
      }
    }
    public void TakeOff(Runway runway)
    {
      Console.WriteLine($"Aircraft {this.Name} is taking off.");
      runway.IsBusyWithAircraft = null;
      this.CurrentRunway = null;
      runway.HighLightGreen();
      Console.WriteLine($"Aircraft {this.Name} has took off.");
    }
  }
}
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
      // @TODO: check conflicting
      Console.WriteLine("Checking conflicting runways");
      runway.IsBusyWithAircraft = null;
      this.CurrentRunway = null;
      Console.WriteLine($"Aircraft {this.Name} has took off.");
    }
  }
}
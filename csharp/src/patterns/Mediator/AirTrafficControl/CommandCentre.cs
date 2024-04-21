namespace DesignPatterns.Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private Dictionary<Runway, Aircraft> _runwayOccupancy = new Dictionary<Runway, Aircraft>();


        public CommandCentre(Runway[] runways)
        {
            this._runways.AddRange(runways);

            foreach (var runway in runways)
            {
                runway.IsAvailable = true;
            }
        }

        public void LandingRequest(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if(runway.IsAvailable == true)
                {
                    runway.IsAvailable = false;
                    _runwayOccupancy.Add(runway, aircraft);
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}");
                    runway.HighLightRed();
                    return;
                }
            }
            Console.WriteLine($"Could not land, all runways are busy.");
        }

        public void TakingOffRequest(Aircraft aircraft)
        {
            foreach (var busyline in _runwayOccupancy)
            {
                if(busyline.Value == aircraft)
                {
                    busyline.Key.IsAvailable = true;
                    _runwayOccupancy.Remove(busyline.Key);
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off from line {busyline.Key.Id}");
                    busyline.Key.HighLightGreen();
                    _runwayOccupancy.Remove(busyline.Key);
                    return;
                }
            }
            Console.WriteLine($"Aircraft can`t be found. Taking off is declined.");
        }
    }
}
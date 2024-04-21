namespace DesignPatterns.Mediator
{
    class  Aircraft
    {

        public string Name;
        public bool IsTakingOff { get; set; } = false;
        private CommandCentre _commandCentre {  get; set; }

        public Aircraft(string name, CommandCentre centre)
        {
            this.Name = name;
            this._commandCentre = centre;
        }
        
        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            Console.WriteLine($"Checking runway.");

            _commandCentre.LandingRequest(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
            _commandCentre.TakingOffRequest(this);
            Console.WriteLine($"Aircraft {this.Name} has took off.");
        }
    }
}
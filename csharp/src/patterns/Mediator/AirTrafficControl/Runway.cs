namespace DesignPatterns.Mediator
{
    class Runway
    {
        public bool IsAvailable { get; set; }
        public readonly Guid Id = Guid.NewGuid();

        public void HighLightRed()
        {
            Console.WriteLine($"Now runway {this.Id} is busy!");
        }
        
        public void HighLightGreen()
        {
            Console.WriteLine($"Now runway {this.Id} is free!");
        }
    }
}
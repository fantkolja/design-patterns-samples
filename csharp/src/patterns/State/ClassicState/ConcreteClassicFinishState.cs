namespace DesignPatterns.State
{
  class ConcreteClassicFinishState : IClassicState
  {
    public void Initiate()
    {
      Console.WriteLine("Ending the game");
    }

    public void End()
    {
      Console.WriteLine("Exiting from the process!");
    }
  }
}











// Version #2 with Context passed as an arg
// namespace DesignPatterns.State
// {
//   class ConcreteClassicFinishState : IClassicState
//   {
//     public void Initiate()
//     {
//       Console.WriteLine("Ending the game");
//     }

//     public void End(ClassicContext _ctx)
//     {
//       Console.WriteLine("Exiting from the process!");
//     }
//   }
// }
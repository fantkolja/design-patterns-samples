namespace DesignPatterns.State
{
  class ConcreteClassicStartState : IClassicState
  {
    private ClassicContext? _context;
    public void Initiate()
    {
      Console.WriteLine("Starting the game");
    }

    public void End()
    {
      Console.WriteLine("Switching to the FINISH state");
      if (this._context == null) {
        throw new Exception("No state context provided!");
      } else {
        this._context.ChangeState(new ConcreteClassicFinishState());
      }
    }

    public void SetContext(ClassicContext ctx)
    {
      this._context = ctx;
    }
  }
}










// Version #2 with Context passed as an arg

// namespace DesignPatterns.State
// {
//   class ConcreteClassicStartState : IClassicState
//   {
//     public void Initiate()
//     {
//       Console.WriteLine("Starting the game");
//     }

//     public void End(ClassicContext ctx)
//     {
//       Console.WriteLine("Switching to the FINISH state");
//       ctx.ChangeState(new ConcreteClassicFinishState());
//     }
//   }
// }
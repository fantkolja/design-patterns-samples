namespace DesignPatterns.State
{
  class StartState : IState
  {
    private Context? _context;
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
        this._context.ChangeState(new FinishState());
      }
    }

    public void SetContext(Context ctx)
    {
      this._context = ctx;
    }
  }
}










// Version #2 with Context passed as an arg

// namespace DesignPatterns.State
// {
//   class StartState : IState
//   {
//     public void Initiate()
//     {
//       Console.WriteLine("Starting the game");
//     }

//     public void End(Context ctx)
//     {
//       Console.WriteLine("Switching to the FINISH state");
//       ctx.ChangeState(new ConcreteClassicFinishState());
//     }
//   }
// }
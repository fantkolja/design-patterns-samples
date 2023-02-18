namespace DesignPatterns.State
{
  class ClassicContext : IClassicState
  {
    private IClassicState _state;

    public void ChangeState(IClassicState state)
    {
      this._state = state;
    }

    public void Initiate()
    {
      this._state.Initiate();
    }

    public void End()
    {
      this._state.End();
    }

    public ClassicContext(IClassicState initialState)
    {
      this._state = initialState;
    }
  }
}


// using DesignPatterns.State;

// var initialState = new ConcreteClassicStartState();
// ClassicContext ctx = new(initialState);
// initialState.SetContext(ctx);

// ctx.Initiate();
// ctx.End();
// ctx.Initiate();
// ctx.End();
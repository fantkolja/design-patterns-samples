namespace DesignPatterns.State
{
  class Context : IState
  {
    private IState _state;

    public void ChangeState(IState state)
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

    public Context(IState initialState)
    {
      this._state = initialState;
    }
  }
}


// using DesignPatterns.State;

// var initialState = new StartState();
// var ctx = new Context(initialState);
// initialState.SetContext(ctx);

// ctx.Initiate();
// ctx.End();
// ctx.Initiate();
// ctx.End();
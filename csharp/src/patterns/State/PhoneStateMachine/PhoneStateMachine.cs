namespace DesignPatterns.State
{
  class PhoneStateMachine
  {
    private static Dictionary<PhoneState, List<(PhoneStateTrigger, PhoneState)>> _rules = new Dictionary<PhoneState, List<(PhoneStateTrigger, PhoneState)>>()
    {
      [PhoneState.StandBy] = new List<(PhoneStateTrigger, PhoneState)>
      {
        (PhoneStateTrigger.CallDialed, PhoneState.Connecting)
      },
      [PhoneState.Connecting] = new List<(PhoneStateTrigger, PhoneState)>
      {
        (PhoneStateTrigger.HungUp, PhoneState.StandBy),
        (PhoneStateTrigger.CallConnected, PhoneState.Speaking)
      },
      [PhoneState.Speaking] = new List<(PhoneStateTrigger, PhoneState)>
      {
        (PhoneStateTrigger.LeftVoiceMessage, PhoneState.StandBy),
        (PhoneStateTrigger.HungUp, PhoneState.StandBy),
        (PhoneStateTrigger.PlacedOnHold, PhoneState.OnHold)
      },
      [PhoneState.OnHold] = new List<(PhoneStateTrigger, PhoneState)>
      {
        (PhoneStateTrigger.TakenOffHold, PhoneState.Speaking),
        (PhoneStateTrigger.HungUp, PhoneState.StandBy)
      }
    };
    private PhoneState _currentState;

    public PhoneStateMachine()
    {
      this._currentState = PhoneState.StandBy;

      while(true) 
      {
        var possibleStates = PhoneStateMachine._rules[this._currentState];

        Console.WriteLine($"The phone is now {this._currentState}");
        Console.WriteLine("Select next trigger");

        for(var i = 0; i < possibleStates.Count; i++)
        {
          var (trigger, _) = possibleStates[i];
          Console.WriteLine($"{i} => {trigger}");
        }

        int nextTrigger = int.Parse(Console.ReadKey().KeyChar.ToString());

        Console.CursorLeft = 0;

        this._currentState = possibleStates[nextTrigger].Item2;
      }
    }
  }
}
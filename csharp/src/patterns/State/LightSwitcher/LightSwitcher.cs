// SPECIFICATION:
//
// starting with `OFF` state
// "Turning light ON"
// "Light is turned ON"
// "Turning light OFF"
// "Light is turned OFF"


namespace DesignPatterns.State
{
  class LightSwitcher
  {
    public ILightSwitcherState State;

    public LightSwitcher()
    {
      this.State = new LightSwitcherOffState();
    }
    public void On()
    {
      this.State.On(this);
    }
    public void Off()
    {
      this.State.Off(this);
    }
  }
}



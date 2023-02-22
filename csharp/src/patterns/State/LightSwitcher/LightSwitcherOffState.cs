namespace DesignPatterns.State
{
  class LightSwitcherOffState : ILightSwitcherState
  {
    public LightSwitcherOffState()
    {
      Console.WriteLine("Light is turned OFF!");
    }
    public void Off(LightSwitcher switcher)
    {
      Console.WriteLine("Light is already OFF");
    }

    public void On(LightSwitcher switcher)
    {
      Console.WriteLine("Turning light ON...");
      switcher.State = new LightSwitcherOnState();
    }
  }
}
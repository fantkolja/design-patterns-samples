namespace DesignPatterns.State
{
  class LightSwitcherOnState : ILightSwitcherState
  {
    public LightSwitcherOnState()
    {
      Console.WriteLine("Light is turned ON!");
    }
    public void Off(LightSwitcher switcher)
    {
      Console.WriteLine("Turning light OFF...");
      switcher.State = new LightSwitcherOffState();
    }

    public void On(LightSwitcher switcher)
    {
      Console.WriteLine("Light is already ON");
    }
  }
}
namespace DesignPatterns.State
{
  interface ILightSwitcherState
  {
    public void On(LightSwitcher switcher);
    public void Off(LightSwitcher switcher);
  }
}
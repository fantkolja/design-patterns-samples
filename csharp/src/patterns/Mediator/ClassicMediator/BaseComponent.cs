namespace DesignPatterns.Mediator
{
  class BaseComponent
  {
    public Mediator? Mediator { protected get; set; }

    protected void _notifyMediator(string ev)
    {
      if (this.Mediator != null)
      {
        this.Mediator.Notify(ev);
      }
    }
  }
}
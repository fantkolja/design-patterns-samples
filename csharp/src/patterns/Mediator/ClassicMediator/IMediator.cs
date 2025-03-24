namespace DesignPatterns.Mediator
{
  interface IMediator
  {
    public void OnActionA(string ev);
    public void OnActionB(BaseComponent component);
  }
}





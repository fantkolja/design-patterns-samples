namespace DesignPatterns.Mediator
{
  class BaseComponent
  {
    public string Name { get; set; } = "Unknown Component";
    protected IMediator? _mediator;

    public BaseComponent(string? name)
    {
      if (name != null)
      {
        Name = name;
      }
    }

    public void SetMediator(IMediator mediator)
    {
      this._mediator = mediator;
    }
  }
}
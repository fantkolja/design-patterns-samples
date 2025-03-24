namespace DesignPatterns.Mediator
{
  class BaseComponent
  {
    public string Name { get; set; } = "Unknown Component";
    protected IMediator _mediator { get; set; }

    public BaseComponent(IMediator mediator, string? name)
    {
      _mediator = mediator;
      if (name != null)
      {
        Name = name;
      }
    }
  }
}
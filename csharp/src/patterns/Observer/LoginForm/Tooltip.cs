namespace DesignPatterns.Observer
{
  class Tooltip
  {
    private SubmitButton _wrappedButton;

    public Tooltip(SubmitButton wrappedButton)
    {
      this._wrappedButton = wrappedButton;
    }
    public void Show()
    {
      Console.WriteLine("Show tooltip");
    }
    public void Hide()
    {
      Console.WriteLine("Hide tooltip");
    }
  }
}
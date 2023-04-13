namespace DesignPatterns.Observer
{
  class CounterObserver : IEventListener, IInfoDisplayer
  {
    private int _state = 0;
    public void Update(int arg)
    {
      Console.WriteLine("counter update");
      this._state++;
    }

    public void DisplayInfo()
    {
      Console.WriteLine($"The state is: {this._state}");
    }
  }
}
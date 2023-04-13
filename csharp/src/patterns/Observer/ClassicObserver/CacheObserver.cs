namespace DesignPatterns.Observer
{
  class CacheObserver : IEventListener, IInfoDisplayer
  {
    private List<int> _states = new List<int>();
    public void Update(int arg)
    {
      Console.WriteLine("cache update");
      this._states.Add(arg);
    }

    public void DisplayInfo()
    {
      Console.WriteLine($"The states are: {String.Join(", ", this._states)}");
    }
  }
}
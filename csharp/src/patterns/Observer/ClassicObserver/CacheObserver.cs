namespace DesignPatterns.Observer
{
  class CacheObserver : IEventListener, IInfoDisplayer
  {
    private List<int> _states = new List<int>();
    private string _statesInfo => String.Join(", ", this._states);
    public void Update(int arg)
    {
      this._states.Add(arg);
      Console.WriteLine($"cache update: {this._statesInfo}");
    }

    public void DisplayInfo()
    {
      Console.WriteLine($"The states are: {this._statesInfo}");
    }
  }
}
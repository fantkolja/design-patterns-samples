namespace DesignPatterns.Observer
{
  class Subject
  {
    private List<IEventListener> _subscribers = new List<IEventListener>();
    public void Subscribe(IEventListener subscriber)
    {
      this._subscribers.Add(subscriber);
    }
    public void Unsubscribe(IEventListener subscriber)
    {
      this._subscribers.Remove(subscriber);
    }

    private void _notify(int arg)
    {
      this._subscribers.ForEach((s) => s.Update(arg));
    }

    public void InvokeEvent(int arg)
    {
      this._notify(arg);
    }
  }
}
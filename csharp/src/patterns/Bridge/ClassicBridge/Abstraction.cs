namespace DesignPatterns.Bridge
{
  class Abstraction
  {
    protected Implementor _impl;

    public Abstraction(Implementor impl)
    {
      this._impl = impl;
    }

    public virtual void Operation1()
    {
      this._impl.DoSomethingA();
    }

    public virtual void Operation2()
    {
      this._impl.DoSomethingB();
      this._impl.DoSomethingA();
    }
  }
}
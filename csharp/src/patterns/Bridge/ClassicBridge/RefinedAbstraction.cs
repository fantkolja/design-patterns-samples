namespace DesignPatterns.Bridge
{
  class RefinedAbstraction : Abstraction
  {
    public RefinedAbstraction(Implementor impl) : base(impl)
    {
    }

    public void Operation3()
    {
      this._impl.DoSomethingB();
      this._impl.DoSomethingA();
    }
  }
}
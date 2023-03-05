namespace DesignPatterns.Adapter
{
  class ClassicAdaptor : ClassicTarget
  {
    private ClassicAdaptee _adaptee;
    public override int DoSomething()
    {
      return this._adaptee.DoSomethingInAnotherWay(3);
    }

    public ClassicAdaptor(ClassicAdaptee adaptee)
    {
      this._adaptee = adaptee;
    }
  }
}
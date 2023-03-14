namespace DesignPatterns.Adapter
{
  class ClassicAdapter : ClassicTarget
  {
    private ClassicAdaptee _adaptee;
    public override int DoSomething()
    {
      return this._adaptee.DoSomethingInAnotherWay(3);
    }

    public ClassicAdapter(ClassicAdaptee adaptee)
    {
      this._adaptee = adaptee;
    }
  }
}
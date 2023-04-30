namespace DesignPatterns.TemplateMethod
{
  abstract class Template
  {
    public void TemplateMethod()
    {
      this._onStart();
      this._step1();
      if (this._shouldProceedToStep2())
      {
        this._shouldProceedToStep2();
        if (this._shouldProceedToStep3())
        {
          this._shouldProceedToStep3();
        }
      }
      this._onEnd();
    }

    abstract protected void _onStart();
    protected virtual void _step1()
    {
      Console.WriteLine("Default Step1 implementation");
    }
    protected virtual bool _shouldProceedToStep2()
    {
      return true;
    }
    protected virtual void _step2()
    {
      Console.WriteLine("Default Step2 implementation");
    }
    protected virtual bool _shouldProceedToStep3()
    {
      return true;
    }
    protected virtual void _step3()
    {
      Console.WriteLine("Default Step3 implementation");
    }
    protected virtual void _onEnd()
    {
      
    }
  }
}
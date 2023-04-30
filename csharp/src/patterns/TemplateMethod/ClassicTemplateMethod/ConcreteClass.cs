namespace DesignPatterns.TemplateMethod
{
  class ConcreteClass : Template
  {
    protected override void _onStart()
    {
      Console.WriteLine("ConcreteClass has started his work");
    }
    protected override void _step1()
    {
      Console.WriteLine("First I do this");
    }
    protected override void _step2()
    {
      Console.WriteLine("Then I do this");
    }
    protected override bool _shouldProceedToStep3()
    {
      return false;
    }
    protected override void _onEnd()
    {
      Console.WriteLine("ConcreteClass has ended his work");
    }
  }
}




// using DesignPatterns.TemplateMethod;

// var c = new ConcreteClass();
// c.TemplateMethod();
namespace DesignPatterns.Visitor
{
  interface IVisitor
  {
    public int Visit(ConcreteElement1 element);
    public int Visit(ConcreteElement2 element);
  }
}


// using DesignPatterns.Visitor;

// var element1 = new ConcreteElement1();
// var element2 = new ConcreteElement2();

// var doubleVisitor = new DoubleVisitor();
// var tripleVisitor = new TripleVisitor();

// IVisitor currentVisitor = new Random().Next() > Int32.MaxValue / 2 ? doubleVisitor : tripleVisitor;

// element1.Accept(currentVisitor);
// element2.Accept(currentVisitor);
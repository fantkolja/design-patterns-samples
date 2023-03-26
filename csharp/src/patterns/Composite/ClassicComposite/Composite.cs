using System.Collections;

namespace DesignPatterns.Composite
{
  class Composite : IComponent
  {
    private List<IComponent> _children = new List<IComponent>();
    public void Operation()
    {
      this._children.ForEach(child => child.Operation());
    }

    public void AddChild(IComponent child)
    {
      this._children.Add(child);
    }

    public void RemoveAt(int index)
    {
      this._children.RemoveAt(index);
    }
  }
}




// using DesignPatterns.Composite;

// var l1 = new Leaf("a");
// var l2 = new Leaf("b");
// var l3 = new Leaf("c");
// var l4 = new Leaf("d");

// var c1 = new Composite();
// var c2 = new Composite();

// c1.AddChild(l1);
// c1.AddChild(c2);
// c2.AddChild(l2);
// c2.AddChild(l3);
// c2.AddChild(l4);

// c1.Operation();
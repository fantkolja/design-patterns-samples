using System.Text;

namespace DesignPatterns.Memento
{
  class ClassicOriginator
  {
    private int _state;
    public ClassicOriginator(int initialState)
    {
      this._state = initialState;
      this._doSomething();
    }

    private void _doSomething()
    {
      var thread = new Thread(() => {
        while(true) {
          Thread.Sleep(500);
          this._state++;
        }
      });
      thread.Start();
    }

    public override string ToString()
    {
      return $"Internal state is now {this._state}";
    }

    public IClassicMemento Save()
    {
      return new ClassicConcreteMemento(this._state);
    }

    public void Restore(IClassicMemento snapshot)
    {
      if (snapshot is ClassicConcreteMemento) {
        var memento = (ClassicConcreteMemento)snapshot;
        this._state = memento.GetState();
      } else {
        throw new ArgumentException("The snapshot is not of type ClassicConcreteMemento");
      }
    }
  }
}

























// using DesignPatterns.Memento;

// var originator = new ClassicOriginator(0);
// var caretaker = new ClassicCaretaker(originator);

// for(int i = 0; i < 3; i++)
// {
//   Thread.Sleep(1000);
//   caretaker.Backup();
// }

// caretaker.RenderSnapshotList();
// Console.WriteLine(originator);
// caretaker.Undo();
// caretaker.Undo();
// Console.WriteLine(originator);

// caretaker.RenderSnapshotList();
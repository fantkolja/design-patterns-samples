// namespace DesignPatterns.Memento
// {
//   class ClassicCaretaker
//   {
//     private ClassicOriginator _originator;
//     private List<IClassicMemento> _snapshots = new List<IClassicMemento>();

//     public ClassicCaretaker(ClassicOriginator originator)
//     {
//       this._originator = originator;
//     }

//     public void Backup()
//     {
//       this._snapshots.Add(this._originator.Save());
//     }

//     public void Undo()
//     {
//       var snapshot = this._snapshots.Last();
//       this._originator.Restore(snapshot);
//       this._snapshots.Remove(snapshot);
//     }

//     public void RenderSnapshotList()
//     {
//       Console.WriteLine("Currently availbale snapshots:");
//       this._snapshots.ForEach((snapshot) => {
//         Console.WriteLine($"{snapshot.Id}: {snapshot.Date}");
//         // snapshot.GetState() is not available for the Caretaker
//       });
//     }
//   }
// }
















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

// Console.WriteLine("");
// caretaker.Undo();
// caretaker.Undo();
// Console.WriteLine(originator);

// Console.WriteLine("");
// caretaker.RenderSnapshotList();
























// Version #2: Strcit Encapsulation

namespace DesignPatterns.Memento
{
  class ClassicCaretaker
  {
    private List<IClassicMemento> _snapshots = new List<IClassicMemento>();

    public void Backup(IClassicMemento snapshot)
    {
      this._snapshots.Add(snapshot);
    }

    public void Undo()
    {
      var snapshot = this._snapshots.Last();
      snapshot.Restore();

      this._snapshots.Remove(snapshot);
    }

    public void RenderSnapshotList()
    {
      Console.WriteLine("Currently availbale snapshots:");
      this._snapshots.ForEach((snapshot) => {
        Console.WriteLine($"{snapshot.Id}: {snapshot.Date}");
        // snapshot.GetState() is not available for the Caretaker
      });
    }
  }
}



// using DesignPatterns.Memento;

// var originator = new ClassicOriginator(0);
// var caretaker = new ClassicCaretaker();

// for(int i = 0; i < 3; i++)
// {
//   Thread.Sleep(1000);
//   caretaker.Backup(originator.Save());
// }

// caretaker.RenderSnapshotList();
// Console.WriteLine(originator);

// Console.WriteLine("");
// caretaker.Undo();
// caretaker.Undo();
// Console.WriteLine(originator);

// Console.WriteLine("");
// caretaker.RenderSnapshotList();
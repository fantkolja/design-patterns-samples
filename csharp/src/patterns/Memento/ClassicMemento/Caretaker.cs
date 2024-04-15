namespace DesignPatterns.Memento
{
  class Caretaker
  {
    private Originator _originator;
    private List<IMemento> _snapshots = new List<IMemento>();

    public Caretaker(Originator originator)
    {
      this._originator = originator;
    }

    public void Backup()
    {
      this._snapshots.Add(this._originator.Save());
    }

    public void Undo()
    {
      var snapshot = this._snapshots.Last();
      Console.WriteLine($"Undo {snapshot.Id}");
      this._originator.Restore(snapshot);
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

// var originator = new Originator(0);
// var caretaker = new Caretaker(originator);

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

// namespace DesignPatterns.Memento
// {
//   class Caretaker
//   {
//     private List<IMemento> _snapshots = new List<IMemento>();

//     public void Backup(IMemento snapshot)
//     {
//       this._snapshots.Add(snapshot);
//     }

//     public void Undo()
//     {
//       var snapshot = this._snapshots.Last();
//       snapshot.Restore();

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

// IOriginator originator = new Originator(0);
// var caretaker = new Caretaker();

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
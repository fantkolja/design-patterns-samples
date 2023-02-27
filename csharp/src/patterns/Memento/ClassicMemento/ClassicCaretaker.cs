namespace DesignPatterns.Memento
{
  class ClassicCaretaker
  {
    private ClassicOriginator _originator;
    private List<IClassicMemento> _snapshots = new List<IClassicMemento>();

    public ClassicCaretaker(ClassicOriginator originator)
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
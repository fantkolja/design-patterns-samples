using DesignPatterns.Memento;

var originator = new ClassicOriginator(0);
var caretaker = new ClassicCaretaker();

for(int i = 0; i < 3; i++)
{
  Thread.Sleep(1000);
  caretaker.Backup(originator.Save());
}

caretaker.RenderSnapshotList();
Console.WriteLine(originator);

Console.WriteLine("");
caretaker.Undo();
caretaker.Undo();
Console.WriteLine(originator);

Console.WriteLine("");
caretaker.RenderSnapshotList();

Console.WriteLine("");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);

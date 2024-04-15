using DesignPatterns.Memento;

var originator = new Originator(0);
var caretaker = new Caretaker(originator);

for(int i = 0; i < 3; i++)
{
  Thread.Sleep(1000);
  caretaker.Backup();
}

caretaker.RenderSnapshotList();
Console.WriteLine(originator);

Console.WriteLine("");
caretaker.Undo();
caretaker.Undo();
Console.WriteLine(originator);

Console.WriteLine("");
caretaker.RenderSnapshotList();

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
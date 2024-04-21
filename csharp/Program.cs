using DesignPatterns.Mediator;
 
Runway[] runways = { new Runway(), new Runway() };
CommandCentre commandCentre = new CommandCentre(runways);

Aircraft aircraft1 = new Aircraft("A1", commandCentre);
Aircraft aircraft2 = new Aircraft("A2", commandCentre);
Aircraft aircraft3 = new Aircraft("A3", commandCentre);

aircraft1.Land();
aircraft2.Land();
aircraft3.Land();

aircraft1.TakeOff();
aircraft2.TakeOff();

aircraft3.Land();

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
using DesignPatterns.State;

var switcher = new LightSwitcher();

switcher.On();
switcher.On();
switcher.Off();
switcher.Off();

Console.WriteLine("");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);

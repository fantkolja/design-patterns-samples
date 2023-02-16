using DesignPatterns.Command;

Account mykolasAccount = new(10);

IAccountCommand deposit1 = new DepositCommand(mykolasAccount, 50);
IAccountCommand deposit2 = new DepositCommand(mykolasAccount, 50);
IAccountCommand withdraw1 = new DepositCommand(mykolasAccount, 60);
IAccountCommand withdraw2 = new DepositCommand(mykolasAccount, 50);



Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
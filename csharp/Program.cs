using DesignPatterns.Command;

Account mykolasAccount = new(10);

List<IAccountCommand> operations = new List<IAccountCommand>(){
  new DepositCommand(mykolasAccount, 50),
  new DepositCommand(mykolasAccount, 50),
  new WithdrawCommand(mykolasAccount, 60),
  new WithdrawCommand(mykolasAccount, 50),
};

 operations.ForEach(cmd => cmd.Call());

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
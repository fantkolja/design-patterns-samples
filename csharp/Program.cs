using DesignPatterns.Memento;

var myAccount = new BankAccount(100, "UAH");

myAccount.Deposit(100);
myAccount.Deposit(200);
myAccount.Deposit(-30);
myAccount.ChangeCurrency("USD");
myAccount.Deposit(20);

Console.WriteLine($"Current account: {myAccount}");

myAccount.Restore(3);
Console.WriteLine($"Restored account: {myAccount}");

Console.WriteLine("");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);

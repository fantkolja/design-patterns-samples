namespace DesignPatterns.Command
{
  class BankingSession
  {
    private List<IAccountCommand> _operations = new List<IAccountCommand>();
    Account mykolasAccount = new(10);

    public BankingSession(List<IAccountCommand> operations)
    {
      this._operations = operations;
    }

    public bool RunTransaction()
    {
       this._operations.ForEach(cmd => cmd.Call());
       return true;
    }
  }
}

// Account mykolasAccount = new(10);

// BankingSession session = new(new List<IAccountCommand>(){
//   new DepositCommand(mykolasAccount, 50),
//   new WithdrawCommand(mykolasAccount, 60),
//   new DepositCommand(mykolasAccount, 50),
//   new WithdrawCommand(mykolasAccount, 50),
// });

// session.RunTransaction();








// Version #2 with RevertTransaction

// namespace DesignPatterns.Command
// {
//   class BankingSession
//   {
//     private List<IAccountCommand> _operations = new List<IAccountCommand>();
//     Account mykolasAccount = new(10);

//     public BankingSession(List<IAccountCommand> operations)
//     {
//       this._operations = operations;
//     }

//     public bool RunTransaction()
//     {
//       bool success = false;
//       try {
//         this._operations.ForEach(cmd => {
//           cmd.Call();
//           cmd.HasRun = true;
//       });
//         success = true;
//       } catch(ArgumentException err) {
//         Console.WriteLine($"{err.Message}. Reverting transaction");
//         this.RevertTransaction();
//       }
       
//       return success;
//     }

//     public bool RevertTransaction()
//     {
//       var reversedOperations = Enumerable.Reverse(this._operations).ToList();
//       reversedOperations.ForEach(cmd => {
//         if (cmd.HasRun)
//         {
//           cmd.Undo();
//           cmd.HasRun = false;
//         }
//       });
//       return true;
//     }
//   }
// }

// Account mykolasAccount = new(10);

// BankingSession session = new(new List<IAccountCommand>(){
//   new DepositCommand(() => mykolasAccount.Deposit(50), () => mykolasAccount.Withdraw(50)),
//   new DepositCommand(() => mykolasAccount.Withdraw(60), () => mykolasAccount.Deposit(60)),
//   new DepositCommand(() => mykolasAccount.Withdraw(50), () => mykolasAccount.Deposit(50)),
//   new DepositCommand(() => mykolasAccount.Deposit(50), () => mykolasAccount.Withdraw(50)),
// });

// session.RunTransaction();












// Version #3: Revert without Command flag => with CallStack

// namespace DesignPatterns.Command
// {
//   class BankingSession
//   {
//     private List<IAccountCommand> _operations = new List<IAccountCommand>();
//     Account mykolasAccount = new(10);

//     public BankingSession(List<IAccountCommand> operations)
//     {
//       this._operations = operations;
//     }

//     public bool RunTransaction()
//     {
//       Stack<IAccountCommand> succeededCommands = new();
//       try {
//         this._operations.ForEach(cmd => {
//           cmd.Call();
//           succeededCommands.Push(cmd);
//       });
//       } catch(ArgumentException err) {
//         Console.WriteLine($"{err.Message}. Reverting transaction");
//         this.RevertTransaction(succeededCommands);
//       }
       
//       return succeededCommands.Count == this._operations.Count;
//     }

//     public bool RevertTransaction( Stack<IAccountCommand> commands)
//     {
//       Console.WriteLine(commands.Count);
//       commands.ToList().ForEach(cmd => {
//         cmd.Undo();
//       });
//       return true;
//     }
//   }
// }
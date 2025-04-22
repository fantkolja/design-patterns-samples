namespace DesignPatterns.Command
{
  class BankingSession
  {
    private List<IAccountCommand> _operations = new List<IAccountCommand>();
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











// var mykolasAccount = new Account(10);


// var operations = new List<IAccountCommand>(){
//   new DepositCommand(mykolasAccount, 50),
//   new WithdrawCommand(mykolasAccount, 60),
//   new DepositCommand(mykolasAccount, 50),
//   new WithdrawCommand(mykolasAccount, 50),
// };
// var session = new BankingSession(operations);

// session.RunTransaction();



















// Version #2: Revert with CallStack

// namespace DesignPatterns.Command
// {
//   class BankingSession
//   {
//     private Queue<IAccountCommand> _operations = new Queue<IAccountCommand>();
//     public BankingSession(Queue<IAccountCommand> operations)
//     {
//       this._operations = operations;
//     }

//     public bool RunTransaction()
//     {
//       Stack<IAccountCommand> succeededCommands = new();
//       try {
//         while (this._operations.Count > 0) {
//           var operation = this._operations.Dequeue();
//           operation.Call();
//           succeededCommands.Push(operation);
//         }
//       } catch(ArgumentException err) {
//         Console.WriteLine($"{err.Message} => Reverting transaction");
//         this.RevertTransaction(succeededCommands);
//       }

//       return succeededCommands.Count == this._operations.Count;
//     }

//     public bool RevertTransaction( Stack<IAccountCommand> commands)
//     {
//       Console.WriteLine($"Transactions count to revert: {commands.Count}");
//       while (commands.Count > 0) {
//         var cmd = commands.Pop();
//         cmd.Undo();
//       }
//       return true;
//     }
//   }
// }





// using DesignPatterns.Command;

// var mykolasAccount = new Account(10);


// var operations = new Queue<IAccountCommand>();
// operations.Enqueue(new DepositCommand(mykolasAccount, 50));
// operations.Enqueue(new WithdrawCommand(mykolasAccount, 60));
// operations.Enqueue(new DepositCommand(mykolasAccount, 70));
// operations.Enqueue(new WithdrawCommand(mykolasAccount, 80));
// var session = new BankingSession(operations);

// session.RunTransaction();
namespace DesignPatterns.Command
{
  class DepositCommand : IAccountCommand
  {
    private Account _account;
    private int _amount; 

    public DepositCommand(Account account, int amount)
    {
      this._account = account;
      this._amount = amount;
    }
    public void Call()
    {
      this._account.Deposit(this._amount);
    }

    public void Undo()
    {
      this._account.Withdraw(this._amount);
    }
  }
}









// Version #2: implemention Action delegates

// namespace DesignPatterns.Command
// {
//   class DepositCommand : IAccountCommand
//   {
//     public Action Call { private set; get; }
//     public Action Undo { private set; get; }
//     public DepositCommand(Action call, Action undo)
//     {
//       this.Call = call;
//       this.Undo = undo;
//     }
//   }
// }








// Version #3: with HasRun flag

// namespace DesignPatterns.Command
// {
//   class DepositCommand : IAccountCommand
//   {
//     public Action Call { private set; get; }
//     public Action Undo { private set; get; }

//     public bool HasRun { set; get; } = false;
//     public DepositCommand(Action call, Action undo)
//     {
//       this.Call = call;
//       this.Undo = undo;
//     }
//   }
// }
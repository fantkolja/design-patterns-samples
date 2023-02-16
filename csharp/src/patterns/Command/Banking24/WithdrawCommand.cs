namespace DesignPatterns.Command
{
  class WithdrawCommand : IAccountCommand
  {
    private Account _account;
    private int _amount; 

    public WithdrawCommand(Account account, int amount)
    {
      this._account = account;
      this._amount = amount;
    }
    public void Call()
    {
      this._account.Withdraw(this._amount);
    }

    public void Undo()
    {
      this._account.Deposit(this._amount);
    }
  }
}
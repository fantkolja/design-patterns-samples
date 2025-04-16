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








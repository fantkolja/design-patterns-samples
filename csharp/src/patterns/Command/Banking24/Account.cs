namespace DesignPatterns.Command
{
  class Account
  {
    private int _amount = 0;

    public Account(int initialAmount)
    {
      this._amount = initialAmount;
    }

    public int Deposit(int amount)
    {
      this._amount += amount;
      Console.WriteLine($"Deposited {amount}$; balance is now {this._amount}$");
      return this._amount;
    }

    public int Withdraw(int amount)
    {
      this._amount -= amount;
      Console.WriteLine($"Withdrew {amount}$; balance is now {this._amount}$");
      return this._amount;
    }
  }
}
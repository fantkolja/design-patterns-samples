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

















// Version #2 with withdraw validation
// namespace DesignPatterns.Command
// {
//   class Account
//   {
//     private int _amount = 0;

//     public Account(int initialAmount)
//     {
//       this._amount = initialAmount;
//     }

//     public int Deposit(int amount)
//     {
//       this._amount += amount;
//       Console.WriteLine($"Deposited {amount}$; balance is now {this._amount}$");
//       return this._amount;
//     }

//     public int Withdraw(int amount)
//     {
//       if (amount > this._amount) {
//         throw new ArgumentException("Insufficient money!");
//       }
//       this._amount -= amount;
//       Console.WriteLine($"Withdrew {amount}$; balance is now {this._amount}$");
//       return this._amount;
//     }
//   }
// }
// naive implementation
namespace DesignPatterns.Memento
{
  class BankAccount
  {
    private List<BankAccount> _history = new List<BankAccount>();
    private double _amount;
    private string _currency;

    public BankAccount(double initialAmount, string currency)
    {
      this._amount = initialAmount;
      this._currency = currency;
      this._history.Add((BankAccount)this.MemberwiseClone());
    }

    public double Deposit(double amountChange)
    {
      if (amountChange == 0)
      {
        throw new ArgumentException("Transactions with 0 sum are not allowed!");
      }
      this._amount += amountChange;
      this._history.Add((BankAccount)this.MemberwiseClone());
      if (amountChange > 0) {
        Console.WriteLine($"Deposited {amountChange}{this._currency}; balance is now {this._amount}{this._currency}");  
      } else {
        Console.WriteLine($"Withdrew {amountChange * -1}{this._currency}; balance is now {this._amount}{this._currency}");
      }
      return this._amount;
    }

    public void ChangeCurrency(string to)
    {
      double changeCourse = new Random().NextDouble();
      this._currency = to;
      this._amount = Math.Round(this._amount * changeCourse, 2);
    }

    public override string ToString()
    {
      return $"{this._amount} {this._currency}";
    }

    public void Restore(int index)
    {
      BankAccount snapshot = this._history[index];
      this._amount = snapshot._amount;
      this._currency = snapshot._currency;
    }

    public void Undo()
    {
      throw new NotImplementedException();
    }
    public void PrintTransactions()
    {
      throw new NotImplementedException();
    }
  }
}

// Possible improvements: 
//  - decouple History-related logic













// Attempt #2: with decoupled logic
// namespace DesignPatterns.Memento
// {
//   class BankAccount
//   {
//     private BankAccountHistory _history = new BankAccountHistory();
//     private double _amount;

//     public Account(double initialAmount)
//     {
//       this._amount = initialAmount;
//       this._history.Save(initialAmount);
//     }

//     public double Deposit(double amountChange)
//     {
//       if (amountChange == 0)
//       {
//         throw new ArgumentException("Transactions with 0 sum are not allowed!");
//       }
//       this._amount += amountChange;
//       this._history.Save(this._amount);
//       if (amountChange > 0) {
//         Console.WriteLine($"Deposited {amountChange}$; balance is now {this._amount}$");  
//       } else {
//         Console.WriteLine($"Withdrew {amountChange * -1}$; balance is now {this._amount}$");
//       }
//       return this._amount;
//     }

//     public void Restore(int index)
//     {
//       var prevAmount = this._history.Restore(index);
//       this._amount = prevAmount;
//     }
//   }

//   class BankAccountHistory
//   {
//     private List<double> _history = new List<double>();
//     public double Save(double currentAmount)
//     {
//       this._history.Add(currentAmount);
//       return this._history.Count - 1;
//     }
//     public double Restore(double index)
//     {
//       return this._history[index];
//     }
//     // Problem #1: state is exposed to another class "BankAccountHistory"
//   }
// }
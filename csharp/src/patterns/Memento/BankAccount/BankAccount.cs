// naive implementation
namespace DesignPatterns.Memento
{
  class Account
  {
    private List<int> _history = new List<int>();
    private int _amount;

    public Account(int initialAmount)
    {
      this._amount = initialAmount;
      this._history.Add(initialAmount);
    }

    public int Deposit(int amountChange)
    {
      if (amountChange == 0)
      {
        throw new ArgumentException("Transactions with 0 sum are not allowed!");
      }
      this._amount += amountChange;
      this._history.Add(this._amount);
      if (amountChange > 0) {
        Console.WriteLine($"Deposited {amountChange}$; balance is now {this._amount}$");  
      } else {
        Console.WriteLine($"Withdrew {amountChange * -1}$; balance is now {this._amount}$");
      }
      return this._amount;
    }

    public void Restore(int index)
    {
      var prevAmount = this._history[index];
      this._amount = prevAmount;
    }
  }
}

// Possible improvements: 
//  - setter for _amount
//  - decouple History-related logic













// Attempt #2: with decoupled logic
// namespace DesignPatterns.Memento
// {
//   class Account
//   {
//     private List<int> _history = new List<int>();
//     private int _amount;

//     public Account(int initialAmount)
//     {
//       this._amount = initialAmount;
//       this._history.Add(initialAmount);
//     }

//     public int Deposit(int amountChange)
//     {
//       if (amountChange == 0)
//       {
//         throw new ArgumentException("Transactions with 0 sum are not allowed!");
//       }
//       this._amount += amountChange;
//       this._history.Add(this._amount);
//       if (amountChange > 0) {
//         Console.WriteLine($"Deposited {amountChange}$; balance is now {this._amount}$");  
//       } else {
//         Console.WriteLine($"Withdrew {amountChange * -1}$; balance is now {this._amount}$");
//       }
//       return this._amount;
//     }

//     public void Restore(int index)
//     {
//       var prevAmount = this._history[index];
//       this._amount = prevAmount;
//     }
//   }

//   class BankAccountHistory
//   {
//     private List<int> _history = new List<int>();
//     public int Save(int currentAmount)
//     {
//       this._history.Add(currentAmount);
//       return this._history.Count - 1;
//     }
//     public int Restore(int index)
//     {
//       return this._history[index];
//     }
//     // Problem #1: state is exposed to another class "BankAccountHistory"
//     // Problem #2: the logic for list management and the logic for Save/Restore can grow (etc. add Undo, Backups Removal Job)
//   }
// }
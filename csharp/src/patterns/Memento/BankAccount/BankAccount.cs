// naive implementation
namespace DesignPatterns.Memento
{
  class BankAccount
  {
    private List<BankAccount> _history = new List<BankAccount>();
    private List<Guid> _cards = new List<Guid>();
    private string _owner;
    private double _amount;
    private string _currency;

    public BankAccount(string owner, double initialAmount, string currency)
    {
      this._owner = owner;
      this._amount = initialAmount;
      this._currency = currency;
      this._history.Add((BankAccount)this.MemberwiseClone());
      Console.WriteLine($"Account created with initial amount {initialAmount}{currency}");
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
      this._history.RemoveRange(index, this._history.Count - index);
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

// using DesignPatterns.Memento;

// var myAccount = new BankAccount("Mykola", 100, "UAH");

// myAccount.Deposit(100);
// myAccount.Deposit(200);
// myAccount.Deposit(-30);
// myAccount.ChangeCurrency("USD");
// myAccount.Deposit(20);

// Console.WriteLine($"Current account: {myAccount}");

// myAccount.Restore(3);
// Console.WriteLine($"Restored account: {myAccount}");


// Problems:
// #1 Breaks SRP
// #2 Stores big instances of itself 

// Possible improvements: 
// - decouple History-related logic
// - ?



















// namespace DesignPatterns.Memento
// {
//   public interface IBankAccountSnapshot
//   {
//     public Guid Id { get; }
//     public DateTime Date { get; }
//     public void Restore();
//   }
//   class AccountSnapshotManager
//   {
//     private List<IBankAccountSnapshot> _history = new List<IBankAccountSnapshot>();
    
//     public void Save(IBankAccountSnapshot snapshot)
//     {
//       this._history.Add(snapshot);
//     }
//     public void Restore(int index)
//     {
//       var snapshot = this._history.ElementAtOrDefault(index);
//       if (snapshot != null)
//       {
//         snapshot.Restore();
//       }
//     }
//     public void Undo()
//     {
//       throw new NotImplementedException();
//     }
//     public void PrintTransactions()
//     {
//       throw new NotImplementedException();
//     }
//   }
//   class BankAccount
//   {
//     public class BankAccountSnapshot : IBankAccountSnapshot
//     {
//       public Guid Id { get; } = Guid.NewGuid();
//       public DateTime Date { get; } = DateTime.Now;
//       private readonly double _amount;
//       private readonly string _currency;
//       private readonly BankAccount _originalAccount;
//       public BankAccountSnapshot(BankAccount account)
//       {
//         this._amount = account._amount;
//         this._currency = account._currency;
//         this._originalAccount = account;
//       }

//       public void Restore()
//       {
//         this._originalAccount._amount = this._amount;
//         this._originalAccount._currency = this._currency;
//       }
//     }



//     private List<Guid> _cards = new List<Guid>();
//     private string _owner;
//     private double _amount;
//     private string _currency;

//     public BankAccount(string owner, double initialAmount, string currency)
//     {
//       this._owner = owner;
//       this._amount = initialAmount;
//       this._currency = currency;
//     }

//     public double Deposit(double amountChange)
//     {
//       if (amountChange == 0)
//       {
//         throw new ArgumentException("Transactions with 0 sum are not allowed!");
//       }
//       this._amount += amountChange;
//       if (amountChange > 0) {
//         Console.WriteLine($"Deposited {amountChange}{this._currency}; balance is now {this._amount}{this._currency}");  
//       } else {
//         Console.WriteLine($"Withdrew {amountChange * -1}{this._currency}; balance is now {this._amount}{this._currency}");
//       }
//       return this._amount;
//     }

//     public void ChangeCurrency(string to)
//     {
//       double changeCourse = new Random().NextDouble();
//       this._currency = to;
//       this._amount = Math.Round(this._amount * changeCourse, 2);
//     }

//     public IBankAccountSnapshot CreateSnapshot()
//     {
//       return new BankAccountSnapshot(this);
//     }

//     public override string ToString()
//     {
//       return $"{this._amount} {this._currency}";
//     }
//   }
// }


// using DesignPatterns.Memento;

// var myAccount = new BankAccount("Mykola", 100, "UAH");
// var manager = new AccountSnapshotManager();
// manager.Save(myAccount.CreateSnapshot());

// myAccount.Deposit(100);
// manager.Save(myAccount.CreateSnapshot());
// myAccount.Deposit(200);
// manager.Save(myAccount.CreateSnapshot());
// myAccount.Deposit(-30);
// manager.Save(myAccount.CreateSnapshot());
// myAccount.ChangeCurrency("USD");
// myAccount.Deposit(20);
// manager.Save(myAccount.CreateSnapshot());

// Console.WriteLine($"Current account: {myAccount}");

// manager.Restore(3);
// Console.WriteLine($"Restored account: {myAccount}");
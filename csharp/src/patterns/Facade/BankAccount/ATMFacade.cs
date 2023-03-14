namespace DesignPatterns.Facade
{
  class ATMFacade
  {
    private WelcomeToBank _welcomeToBank;
    private AccountNumberChecker _accountNumberChecker;
    private SecurityCodeChecker _securityCodeChecker;
    private BankAccount _account;

    public ATMFacade(BankAccount account)
    {
      this._welcomeToBank = new WelcomeToBank();
      this._accountNumberChecker = new AccountNumberChecker();
      this._securityCodeChecker = new SecurityCodeChecker();
      this._account = account;
    }

    public void RunSession(int accountNumber, int code, int amount)
    {
      this._welcomeToBank.Greet();
      this._accountNumberChecker.IsAccountActive(accountNumber);
      this._securityCodeChecker.IsCodeCorrect(code);
      if (BankAccount.FundsChecker.HasEnoughMoney(this._account, amount))
      {
        this._account.Withdraw(amount);
      }
    }
  }
}







// using DesignPatterns.Facade;

// var atm = new ATMFacade(new BankAccount(5000));
// atm.RunSession(12345678, 1234, 500);
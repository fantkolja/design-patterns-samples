namespace DesignPatterns.Facade
{
  class AccountNumberChecker
  {
    private int _accountNumber = 12345678;
    public bool IsAccountActive(int account)
    {
      return account == this._accountNumber;
    }
  }
}
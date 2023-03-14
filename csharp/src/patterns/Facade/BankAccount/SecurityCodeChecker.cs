namespace DesignPatterns.Facade
{
  class SecurityCodeChecker
  {
    private int _securityCode = 1234;
    public bool IsCodeCorrect(int code)
    {
      return code == this._securityCode;
    }
  }
}
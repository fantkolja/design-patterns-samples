namespace DesignPatterns.Command
{
  interface IAccountCommand
  {
    void Call();
    void Undo();
  }
}
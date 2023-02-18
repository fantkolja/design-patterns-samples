namespace DesignPatterns.Command
{
  interface IAccountCommand
  {
    void Call();
    void Undo();
  }
}






















// Version #2 with Action delegates

// namespace DesignPatterns.Command
// {
//   interface IAccountCommand
//   {
//     Action Call { get; }
//     Action Undo { get; }
//   }
// }

// Version #3 with HasRun flag
// namespace DesignPatterns.Command
// {
//   interface IAccountCommand
//   {
//     Action Call { get; }
//     Action Undo { get; }

//     bool HasRun { get; set; }
//   }
// }
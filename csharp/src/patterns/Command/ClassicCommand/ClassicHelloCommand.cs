namespace DesignPatterns.Command
{
  class ClassicHelloCommand : IClassicCommand
  {
    public void Execute()
    {
      Console.WriteLine("Hello!");
    }

    public void Undo()
    {
      Console.WriteLine("Bye-bye!");
    }
  }
}
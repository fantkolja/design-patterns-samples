namespace DesignPatterns.Command
{
  class ClassicGreetCommand : IClassicCommand
  {
    private string _name;

    public ClassicGreetCommand(string name)
    {
      this._name = name;
    }
    public void Execute()
    {
      Console.WriteLine($"Nice to meet you, {this._name}");
    }

    public void Undo()
    {
      Console.WriteLine($"Back off, {this._name}!!!");
    }
  }
}






// Attempt #1 => in the Main

// IClassicCommand onHello = new ClassicHelloCommand();
// IClassicCommand onGreet = new ClassicGreetCommand("Mykola");

// IClassicCommand[] conversationSequence = { onHello, onGreet };

// foreach (var cmd in conversationSequence)
// {
//   cmd.Execute();
// }

// foreach (var cmd in conversationSequence.Reverse())
// {
//   cmd.Undo();
// }

// Attempt #2 => with an Invoker

// namespace DesignPatterns.Command
// {
//   class ClassicConversationSequenceInvoker
//   {
//     private IClassicCommand _onHello;
//     private IClassicCommand _onGreet;

//     private void SetOnHello(IClassicCommand cmd)
//     {
//       this._onHello = cmd;
//     }
//     public void SetOnGreet(IClassicCommand cmd)
//     {
//       this._onGreet = cmd;
//     }

//     public ClassicConversationSequenceInvoker(IClassicCommand onHello, IClassicCommand onGreet)
//     {
//       this._onHello = onHello;
//       this._onGreet = onGreet;
//     }

//     public void TalkToPerson()
//     {
//       this._onHello.Execute();
//       this._onGreet.Execute();
//     }
//     public void SendPersonAway()
//     {
//       this._onGreet.Undo();
//       this._onHello.Undo();
//     }
//   }
// }


// IClassicCommand onHello = new ClassicHelloCommand();
// IClassicCommand onGreet = new ClassicGreetCommand("Mykola");

// ClassicConversationSequenceInvoker invoker = new ClassicConversationSequenceInvoker(onHello, onGreet);

// invoker.TalkToPerson();
// invoker.SendPersonAway();
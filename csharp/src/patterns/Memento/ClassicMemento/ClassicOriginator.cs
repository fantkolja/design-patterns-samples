namespace DesignPatterns.Memento
{
  class ClassicOriginator
  {
    private int _state;
    public ClassicOriginator(int initialState)
    {
      this._state = initialState;
      this._doSomething();
    }

    private void _doSomething()
    {
      var thread = new Thread(() => {
        while(true) {
          Thread.Sleep(500);
          this._state++;
        }
      });
      thread.Start();
    }

    public override string ToString()
    {
      return $"Internal state is now {this._state}";
    }

    public IClassicMemento Save()
    {
      return new ClassicMemento(this._state);
    }

    public void Restore(IClassicMemento snapshot)
    {
      if (snapshot is ClassicMemento) {
        var memento = (ClassicMemento)snapshot;
        this._state = memento.GetState();
      } else {
        throw new ArgumentException("The snapshot is not of type ClassicMemento");
      }
    }
  }
}





















// Version #2: Strcit Encapsulation

// namespace DesignPatterns.Memento
// {
//   class ClassicOriginator : IClassicOriginator
//   {
//     private int _state;
//     public ClassicOriginator(int initialState)
//     {
//       this._state = initialState;
//       this._doSomething();
//     }

//     private void _doSomething()
//     {
//       var thread = new Thread(() => {
//         while(true) {
//           Thread.Sleep(500);
//           this._state++;
//         }
//       });
//       thread.Start();
//     }

//     public override string ToString()
//     {
//       return $"Internal state is now {this._state}";
//     }

//     public IClassicMemento Save()
//     {
//       return new ClassicMemento(this, this._state);
//     }

//     public void Restore(IClassicMemento snapshot)
//     {
//       if (snapshot is ClassicMemento) {
//         var memento = (ClassicMemento)snapshot;
//         this._state = memento.GetState();
//       } else {
//         throw new ArgumentException("The snapshot is not of type ClassicMemento");
//       }
//     }
//   }
// }
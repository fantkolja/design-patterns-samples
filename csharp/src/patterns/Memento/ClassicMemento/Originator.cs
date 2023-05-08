namespace DesignPatterns.Memento
{
  class Originator
  {
    private int _state;
    public Originator(int initialState)
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

    public IMemento Save()
    {
      return new Memento(this._state);
    }

    public void Restore(IMemento snapshot)
    {
      if (snapshot is Memento) {
        var memento = (Memento)snapshot;
        this._state = memento.GetState();
      } else {
        throw new ArgumentException("The snapshot is not of type Memento");
      }
    }
  }
}





















// Version #2: Strict Encapsulation

// namespace DesignPatterns.Memento
// {
//   class Originator : IOriginator
//   {
//     private int _state;
//     public Originator(int initialState)
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

//     public IMemento Save()
//     {
//       return new Memento(this, this._state);
//     }

//     public void SetState(int state)
//     {
//       this._state = state;
//     }
//   }
// }
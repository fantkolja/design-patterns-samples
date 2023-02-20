/**
* Elevator state matrix
* 
* | State             | CalledFromOutside           | FloorButtonPressed          | CloseDoorsButtonPressed | OpenDoorsButtonPressed |
* | :---:             | :---:                       | :---:                       | :---:                   | :---:                  |
* | StayingClosed     | => StayingOpen || => Moving | => Moving || => StayingOpen | GOTO Open               | GOTO WaitingFaceRecord |
* | StayingOpen       | noop || =>                  | n/a                         | n/a                     | n/a                    |
* | Moving            | n/a                         | n/a                         | n/a                     | n/a                    |
* | Emergency         | n/a                         | n/a                         | n/a                     | n/a                    |
*
*/


/**
* GymTerminal state matrix
* 
* | State   \   Event | BraceletIdentified          | BraceletRejected            | FaceIdentified          | FaceRejected           |
* | :---------------: | :-------------------------: | :-------------------------: | :---------------------: | :--------------------: |
* | EnterStandBy      | n/a                         | n/a                         | n/a                     | n/a                    |
* | ExitStandBy       | n/a                         | n/a                         | n/a                     | n/a                    |
* | CameraOn          | n/a                         | n/a                         | n/a                     | n/a                    |
*
*/


namespace DesignPatterns.State
{
  class GymTerminal
  {
    private void _setBraceletDetectorListeners(BraceletDetector detector)
    {
      
      detector.BraceletIdentified += BraceletIdentifiedEventHandler;
      detector.BraceletRejected += BraceletRejectedEventHandler;
    }

    private void BraceletIdentifiedEventHandler(object? sender, BraceletDetector.BraceletIdentifiedEventArgs e)
    {
      Console.WriteLine($"Identified the bracelet of customer with ID{e.CustomerID} on {e.AtDate.ToShortDateString()} at {e.AtDate.ToShortTimeString()}");
    }

    private void BraceletRejectedEventHandler(object? sender, EventArgs e)
    {
      Console.WriteLine($"Bracelet rejected");
    }
    
    public GymTerminal()
    {
      var detector = new BraceletDetector();
      this._setBraceletDetectorListeners(detector);
      detector.WaitForIncomingSignals();
    }
  }

  class BraceletDetector
  {
    public event EventHandler<BraceletIdentifiedEventArgs>? BraceletIdentified;
    public event EventHandler? BraceletRejected;

    public class BraceletIdentifiedEventArgs : EventArgs
    {
      public Guid CustomerID { get; set; }
      public DateTime AtDate { get; set; }
    }

    public void OnBraceletIdentified(BraceletIdentifiedEventArgs e)
    {
      BraceletIdentified?.Invoke(this, e);
    }

    public void OnBraceletRejected(EventArgs e)
    {
      BraceletRejected?.Invoke(this, e);
    }

    public void WaitForIncomingSignals()
    {
      Console.Clear();
      while(true)
      {
        Console.WriteLine("Touch the screen with your bracelet...");
        ConsoleKeyInfo key = Console.ReadKey();
        Console.SetCursorPosition(0, Console.CursorTop);
        switch (key.KeyChar.ToString().ToUpper())
        {
          case "I":
          {
            this.OnBraceletIdentified(new BraceletIdentifiedEventArgs(){
              CustomerID = Guid.NewGuid(),
              AtDate = DateTime.Now,
            });
            break;
          }
          case "R":
          {
            this.OnBraceletRejected(EventArgs.Empty);
            break;
          }
          default:
            break;
        }
      }
    }
  }
}
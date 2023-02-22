namespace DesignPatterns.State
{
  class WrongPullRequest
  {
    public string State { get; set; } = "draft"; // "edit" "open" "merged" "closed"

    public void OnCreated()
    {
      if (this.State == "draft")
      {

      }
      else if (this.State == "open")
      {

      } 
    }

    public void OnSubmit()
    {
      if (this.State == "draft")
      {

      }
      else if (this.State == "open")
      {

      } 
    }

    public void OnDecline()
    {
      
    }
  }
}








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


  // class Elevator
  // {
  //   public enum State
  //   {
  //     MovingUp,
  //     MovingDown,
  //     Standing,
  //   }
  //   public State CurrentState { get; set; } = State.Standing;
  //   public int CurrentFloor { get; set; } = 1;
  //   public int CurrentDestination { get; set; } = 1;

  //   public void OnUpButtonPress(int floor)
  //   {
  //     if (this.CurrentState == State.MovingUp)
  //     {
  //       if (floor > this.CurrentFloor && floor < this.CurrentDestination) 
  //       {
  //         Console.WriteLine($"Stop on floor {floor} then on {this.CurrentDestination}");
  //       }
  //     }
  //   }
  //   public void OnDownButtonPress(int floor)
  //   {
      
  //   }
  // }
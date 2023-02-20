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
* | State   \   Event | Braceletidentified          | BraceletRejected            | FaceIdentified          | FaceRejected           |
* | :---------------: | :-------------------------: | :-------------------------: | :---------------------: | :--------------------: |
* | EnterStandBy      | n/a                         | n/a                         | n/a                     | n/a                    |
* | ExitStandBy       | n/a                         | n/a                         | n/a                     | n/a                    |
* | CameraOn          | n/a                         | n/a                         | n/a                     | n/a                    |
*
*/


namespace DesignPatterns.State
{
  class Elevator
  {
    
  }
}
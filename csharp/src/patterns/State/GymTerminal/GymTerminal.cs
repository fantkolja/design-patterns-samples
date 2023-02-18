/**
* State matrix
* 
* | State             | CustomerTouch          | FaceRecord            | FaceConfirmation | FaceReject             |
* | :---:             | :---:                  | :---:                 | :---:            | :---:                  |
* | EnterStandBy      | GOTO WaitingFaceRecord | Turn on Camera        | GOTO Open        | GOTO WaitingFaceRecord |
* | ExitStandBy       | GOTO Open              | n/a                   |                  |                        |
* | Open              | n/a (?)                |                       |                  |                        |
* | WaitingFaceRecord | n/a (?)                | GOTO FaceConfirmation | n/a              |                        |
* | Emergency         | n/a                    | n/a                   | n/a              |                        |
*
*/



namespace DesignPatterns.State
{
  class GymTerminal
  {
    
  }
}
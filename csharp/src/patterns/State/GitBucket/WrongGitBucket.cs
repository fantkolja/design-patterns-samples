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
* GymTerminal state matrix
* 
* | State   \   Event | BraceletIdentified          | BraceletRejected            | FaceIdentified          | FaceRejected           |
* | :---------------: | :-------------------------: | :-------------------------: | :---------------------: | :--------------------: |
* | EnterStandBy      | n/a                         | n/a                         | n/a                     | n/a                    |
* | ExitStandBy       | n/a                         | n/a                         | n/a                     | n/a                    |
* | CameraOn          | n/a                         | n/a                         | n/a                     | n/a                    |
*
*/































// namespace DesignPatterns.State
// {
//   class WrongPullRequest
//   {
//     public IGitBucketState State { get; set; } = new OpenGitBucketState();

//     public void OnCreated()
//     {
//       this.State.OnCreated();
//     }

//     public void OnSubmit()
//     {
//       this.State.OnSubmit();
//     }

//     public void OnDecline()
//     {
//       this.State.OnDecline();
//     }
//   }

//   class OpenGitBucketState : IGitBucketState
//   {
//     public void OnCreated()
//     {
//       throw new NotImplementedException();
//     }

//     public void OnDecline()
//     {
//       throw new NotImplementedException();
//     }

//     public void OnSubmit()
//     {
//       throw new NotImplementedException();
//     }
//   }

//   class DraftGitBucketState : IGitBucketState
//   {
//     public void OnCreated()
//     {
//       throw new NotImplementedException();
//     }

//     public void OnDecline()
//     {
//       throw new NotImplementedException();
//     }

//     public void OnSubmit()
//     {
//       throw new NotImplementedException();
//     }
//   }
//   class DeclineGitBucketState : IGitBucketState
//   {
//     public void OnCreated()
//     {
//       throw new NotImplementedException();
//     }

//     public void OnDecline()
//     {
//       // no-op
//     }

//     public void OnSubmit()
//     {
//       throw new NotImplementedException();
//     }
//   }
// }
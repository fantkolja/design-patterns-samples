// Attempt #1

namespace ProgrammingPrinciples.SOLID
{
  class YouTubeAPI
  {
    public bool Open(string url)
    {
      return true;
    }

    public bool Upload(string buffer)
    {
      return true;
    }
  }

  class VideoApp
  {
    private YouTubeAPI _api;

    public VideoApp()
    {
      this._api = new YouTubeAPI();
    }

    public bool PlayVideo(string id)
    {
      this._api.Open(id);
      return true;
    }

    public bool AddVideo(string buffer)
    {
      this._api.Upload(buffer);
      return true;
    }
  }

// New Requirement: add MegogoService
// Please note YouTubeAPI and MegogoAPI are external APIs, we cannot change them
  class MegogoAPI
  {
    public bool TurnOnChannel(string channel)
    {
      return true;
    }

    public bool Buy(string movie)
    {
      return true;
    }
  }

}





// Attempt #2

// namespace ProgrammingPrinciples.SOLID
// {

//   class YouTubeAPI
//   {
//     public bool Open(string url)
//     {
//       return true;
//     }

//     public bool Upload(string buffer)
//     {
//       return true;
//     }
//   }

//   class MegogoAPI
//   {
//     public bool TurnOnChannel(string channel)
//     {
//       return true;
//     }

//     public bool Buy(string id)
//     {
//       return true;
//     }
//   }

//   interface IVideoProvider
//   {
//     public bool GetVideo(string id);
//     public bool AddVideo(string video);
//   }

//   class YouTubeVideoProvider : IVideoProvider
//   {
//     private YouTubeAPI _youTubeAPI = new YouTubeAPI();
//     public bool AddVideo(string url)
//     {
//         return this._youTubeAPI.Open(url);
//     }

//     public bool GetVideo(string buffer)
//     {
//         return this._youTubeAPI.Upload(buffer);
//     }
//   }

//   class MegogoVideoProvider : IVideoProvider
//   {
//     private MegogoAPI _megogoAPI = new MegogoAPI();
//     public bool AddVideo(string channel)
//     {
//         return this._megogoAPI.TurnOnChannel(channel);
//     }

//     public bool GetVideo(string videoName)
//     {
//         return this._megogoAPI.Buy(videoName);
//     }
//   }

//   class VideoApp
//   {
//     private IVideoProvider _videoProvider;

//     public VideoApp(IVideoProvider videoProvider)
//     {
//       this._videoProvider = videoProvider;
//     }

//     public bool PlayVideo(string id)
//     {
//       this._videoProvider.GetVideo(id);
//       return true;
//     }

//     public bool AddVideo(string video)
//     {
//       this._videoProvider.AddVideo(video);
//       return true;
//     }

//     public IVideoProvider ChangeProvider(IVideoProvider videoProvider)
//     {
//       this._videoProvider = videoProvider;
//       return this._videoProvider;
//     }
//   }
// }
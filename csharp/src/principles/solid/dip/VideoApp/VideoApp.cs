namespace ProgrammingPrinciples.SOLID
{

  class YouTubeAPI
  {
    public bool Open()
    {
      return true;
    }

    public bool Upload()
    {
      return true;
    }
  }

  class MegogoAPI
  {
    public bool TurnOnChannel()
    {
      return true;
    }

    public bool Buy()
    {
      return true;
    }
  }

  class VideoApp
  {
    private Dictionary<string, string> _videos = new Dictionary<string, string>();
    private YouTubeAPI _api;

    public VideoApp(YouTubeAPI api)
    {
      this._api = api;
    }

    public bool PlayVideo(string id)
    {
      this._api.Open();
      return true;
    }

    public bool AddVideo(string buffer)
    {
      this._api.Upload();
      return true;
    }
  }
}

// 1 stage => create a common interface
// 2 stage => create a VideoClient
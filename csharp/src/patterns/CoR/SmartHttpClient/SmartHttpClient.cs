namespace DesignPatterns.CoR
{
  class SmartHttpClient
  {
    private HttpClient _client = new HttpClient();
    public Task<string> Fetch(string requestUri)
    {
      if (String.IsNullOrWhiteSpace(requestUri))
      {
        throw new ArgumentException("URL cannot be empty");
      }
      // ...
      return _client.GetStringAsync(requestUri);
    }
  }
}
namespace DesignPatterns.Proxy
{
  class SimpleHttpClient : ISimpleHttpClient
  {
    private HttpClient _client = new HttpClient();
    public Task<string> Fetch(string requestUri)
    {
      return _client.GetStringAsync(requestUri);
    }
  }
}
namespace DesignPatterns.Proxy
{
  interface ISimpleHttpClient
  {
    public Task<string> Fetch(string requestUri);
  }
}
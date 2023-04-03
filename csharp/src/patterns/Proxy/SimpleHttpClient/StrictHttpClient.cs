using System.Text.RegularExpressions;

namespace DesignPatterns.Proxy
{
  class StrictHttpClient : ISimpleHttpClient
  {
    private ISimpleHttpClient _client;
    private Regex _blacklistRegex;

    public StrictHttpClient(ISimpleHttpClient client, string blacklistPattern)
    {
      this._client = client;
      this._blacklistRegex = new Regex(blacklistPattern);
    }

    public Task<string> Fetch(string requestUri)
    {
      if (this._blacklistRegex.IsMatch(requestUri)) 
      {
        throw new Exception($"URL {requestUri} is blacklisted!");
      }
      return _client.Fetch(requestUri);
    }
  }
}














// using DesignPatterns.Proxy;

// ISimpleHttpClient client = new SimpleHttpClient();

// string result = await client.Fetch("https://dummyjson.com/products/1");

// Console.WriteLine(result);
// Console.WriteLine("");

// try
// {
//   ISimpleHttpClient strictClient = new StrictHttpClient(client, "dummyjson");
//   string result2 = await strictClient.Fetch("https://dummyjson.com/products/1");
// } catch (Exception e)
// {
//   Console.WriteLine("Could not process a request");
//   Console.WriteLine(e.Message);
// }



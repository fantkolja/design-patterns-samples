// namespace DesignPatterns.CoR
// {
//   class SmartHttpClient
//   {
//     private HttpClient _client = new HttpClient();
//     public Task<string> Fetch(string requestUri, User user)
//     {
//       string url = requestUri;
//       if (String.IsNullOrWhiteSpace(requestUri))
//       {
//         throw new ArgumentException("URL cannot be empty");
//       }
//       if (!requestUri.StartsWith("https"))
//       {
//         throw new ArgumentException("Only HTTPS requests are allowed");
//       }
//       if (!requestUri.Contains("role="))
//       {
//         url += $"?role={user.UserRole}";
//       }
//       if (user.UserRole != User.Role.Admin)
//       {
//         throw new AccessViolationException("Only Admins can make requests");
//       }
//       // ...
//       return _client.GetStringAsync(url);
//     }
//   }
// }


































using System.Web;

namespace DesignPatterns.CoR
{
  interface IHttpClientInterceptor
  {
    public string Handle(string requestUri, User user);
  }
  abstract class HttpClientInterceptor : IHttpClientInterceptor
  {
    private IHttpClientInterceptor? _next;

    public HttpClientInterceptor SetNext(HttpClientInterceptor next)
    {
      this._next = next;
      return next;
    }
    public virtual string Handle(string requestUri, User user)
    {
      if (this._next == null)
      {
        return requestUri;
      }
      else
      {
        return this._next.Handle(requestUri, user);
      }
    }
  }

  class EmptyStringInterceptor : HttpClientInterceptor
  {
    public override string Handle(string requestUri, User user)
    {

      return base.Handle(requestUri, user);
    }
  }

  class SmartHttpClient
  {
    private HttpClient _client = new HttpClient();
    public Task<string> Fetch(string requestUri, User user)
    {
      string uriString = requestUri;
      if (String.IsNullOrWhiteSpace(requestUri))
      {
        throw new ArgumentException("URL cannot be empty");
      }
      Uri uri = new Uri(uriString);
      if (uri.GetLeftPart(UriPartial.Scheme) != "https://")
      {
        throw new ArgumentException("Only HTTPS requests are allowed");
      }
      
      var uriQuery = HttpUtility.ParseQueryString(uri.Query);
      if (uriQuery.Get("role") == null)
      {
        uriQuery.Set("role", user.UserRole.ToString());
        uriString = uri.GetLeftPart(UriPartial.Path) + "?" + uriQuery;
      }
      if (user.UserRole != User.Role.Admin)
      {
        throw new AccessViolationException("Only Admins can make requests");
      }
      // ...

      Console.WriteLine("Sending a GET request to " + uriString);
      return _client.GetStringAsync(uriString);
    }
  }
}
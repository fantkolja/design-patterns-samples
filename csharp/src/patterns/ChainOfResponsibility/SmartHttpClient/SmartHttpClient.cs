using System.Web;

namespace DesignPatterns.ChainOfResponsibility
{
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



// using DesignPatterns.ChainOfResponsibility;

// var client = new SmartHttpClient();
// var wrongUser = new User(User.Role.User);
// var rightUser = new User(User.Role.Admin);

// static void TestFetch(Action fetch)
// {
//   try 
//   {
//     fetch();
//   }
//   catch (Exception error)
//   {
//     Console.WriteLine("An error has occured...");
//     Console.WriteLine(error.Message);
//   }
// }

// Console.WriteLine("Testing with empty string");
// TestFetch(() => client.Fetch("", wrongUser));

// Console.WriteLine("");
// Console.WriteLine("Testing with HTTP");
// TestFetch(() => client.Fetch("http://dummyjson.com/products/1", rightUser));

// Console.WriteLine("");
// Console.WriteLine("Testing with wrong user");
// TestFetch(() => client.Fetch("https://dummyjson.com/products/1", wrongUser));

// Console.WriteLine("");
// Console.WriteLine("Testing with correct params");
// TestFetch(() => client.Fetch("https://dummyjson.com/products/1", rightUser));


































// using System.Web;

// namespace DesignPatterns.ChainOfResponsibility
// {
//   interface IHttpClientInterceptor
//   {
//     public string Handle(string requestUri, User user);
//   }
//   abstract class HttpClientInterceptor : IHttpClientInterceptor
//   {
//     private IHttpClientInterceptor? _next;

//     public HttpClientInterceptor SetNext(HttpClientInterceptor next)
//     {
//       this._next = next;
//       return next;
//     }
//     public virtual string Handle(string requestUri, User user)
//     {
//       if (this._next == null)
//       {
//         return requestUri;
//       }
//       else
//       {
//         return this._next.Handle(requestUri, user);
//       }
//     }
//   }

//   class EmptyStringInterceptor : HttpClientInterceptor
//   {
//     public override string Handle(string requestUri, User user)
//     {
//       if (String.IsNullOrWhiteSpace(requestUri))
//       {
//         throw new ArgumentException("URL cannot be empty");
//       }
//       return base.Handle(requestUri, user);
//     }
//   }
//   class SchemeInterceptor : HttpClientInterceptor
//   {
//     public override string Handle(string requestUri, User user)
//     {
//       Uri uri = new Uri(requestUri);
//       if (uri.GetLeftPart(UriPartial.Scheme) != "https://")
//       {
//         throw new ArgumentException("Only HTTPS requests are allowed");
//       }
//       return base.Handle(requestUri, user);
//     }
//   }
//   class QueryInterceptor : HttpClientInterceptor
//   {
//     public override string Handle(string requestUri, User user)
//     {
//       string uriString = requestUri;
//       Uri uri = new Uri(uriString);
//       var uriQuery = HttpUtility.ParseQueryString(uri.Query);
//       if (uriQuery.Get("role") == null)
//       {
//         uriQuery.Set("role", user.UserRole.ToString());
//         uriString = uri.GetLeftPart(UriPartial.Path) + "?" + uriQuery;
//       }
//       return base.Handle(uriString, user);
//     }
//   }

//   class UserRoleInterceptor : HttpClientInterceptor
//   {
//     public override string Handle(string requestUri, User user)
//     {
//       if (user.UserRole != User.Role.Admin)
//       {
//         throw new AccessViolationException("Only Admins can make requests");
//       }
//       return base.Handle(requestUri, user);
//     }
//   }

//   class SmartHttpClient
//   {
//     private HttpClient _client = new HttpClient();
//     public Task<string> Fetch(string requestUri, User user)
//     {
//       var emptyStringInterceptor = new EmptyStringInterceptor();
//       var schemeInterceptor = new SchemeInterceptor();
//       var queryInterceptor = new QueryInterceptor();
//       var userRoleinterceptor = new UserRoleInterceptor();
      
//       emptyStringInterceptor
//         .SetNext(schemeInterceptor)
//         .SetNext(queryInterceptor)
//         .SetNext(userRoleinterceptor);

//       string uriString = emptyStringInterceptor.Handle(requestUri, user);
   
//       Console.WriteLine("Sending a GET request to " + uriString);
//       return _client.GetStringAsync(uriString);
//     }
//   }
// }
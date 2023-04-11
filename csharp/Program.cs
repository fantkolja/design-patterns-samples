using DesignPatterns.CoR;

var client = new SmartHttpClient();
var wrongUser = new User(User.Role.User);
var rightUser = new User(User.Role.Admin);

static void TestFetch(Action fetch)
{
  try 
  {
    fetch();
  }
  catch (Exception error)
  {
    Console.WriteLine("An error has occured...");
    Console.WriteLine(error.Message);
  }
}

Console.WriteLine("Testing with empty string");
TestFetch(() => client.Fetch("", wrongUser));

Console.WriteLine("");
Console.WriteLine("Testing with HTTP");
TestFetch(() => client.Fetch("http://dummyjson.com/products/1", rightUser));

Console.WriteLine("");
Console.WriteLine("Testing with wrong user");
TestFetch(() => client.Fetch("https://dummyjson.com/products/1", wrongUser));

Console.WriteLine("");
Console.WriteLine("Testing with correct params");
TestFetch(() => client.Fetch("https://dummyjson.com/products/1", rightUser));


Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
using DesignPatterns.CoR;

var client = new SmartHttpClient();
var user = new User(User.Role.Admin);

client.Fetch("https://dummyjson.com/products/1", user);

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.SetCursorPosition(0, Console.CursorTop);
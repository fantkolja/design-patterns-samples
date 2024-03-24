using System.Diagnostics;

namespace DesignPatterns.Flyweight
{
  static class MemoryMonitor
  {
    public static void CheckCurrentProcess()
    {
      Process proc = Process.GetCurrentProcess();
      // It's 0 on macOS https://github.com/dotnet/runtime/issues/23284
      Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64.ToSmallestFullSize()}");
      Console.WriteLine($"Allocated Physical Memory: {proc.WorkingSet64.ToSmallestFullSize()}");
    }
  }
}
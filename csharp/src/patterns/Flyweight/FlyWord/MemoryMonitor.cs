using System.Diagnostics;

namespace DesignPatterns.Flyweight
{
  static class MemoryMonitor
  {
    public static void CheckCurrentProcess()
    {
      Process proc = Process.GetCurrentProcess();
      Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64.ToSmallestFullSize()}");
      Console.WriteLine($"Physical Memory Usage: {proc.WorkingSet64.ToSmallestFullSize()}");
    }
  }
}
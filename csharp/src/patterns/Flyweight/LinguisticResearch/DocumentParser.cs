using System.Diagnostics;

namespace DesignPatterns.Flyweight
{
  class DocumentParser
  {
    public DocumentParser()
    {
      Process proc = Process.GetCurrentProcess();
      Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64.ToSmallestFullSize()}");
      Console.WriteLine($"Physical memory usage: {proc.WorkingSet64.ToSmallestFullSize()}");
    }
  }
}
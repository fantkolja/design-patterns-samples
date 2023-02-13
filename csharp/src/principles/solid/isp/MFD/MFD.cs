// Attempt #1
namespace ProgrammingPrinciples.SOLID
{
  interface IMFD
  {
    void Print(string content);
    void Scan(string content);
    void Copy(string content);
  }

  class MFD : IMFD
  {
    public void Print(string content) {
      Console.WriteLine($"Printing {content}");
    }

    public void Scan(string content) {
      Console.WriteLine($"Scanning {content}");
    }

    public void Copy(string content) {
      Console.WriteLine($"Copying {content}");
    }
  }
}


// New requirements: 
// 1. Support old Cannon with Print only
// 2. Support old Xerox with no Copy




// Attempt #2

// namespace ProgrammingPrinciples.SOLID
// {
//   interface IPrinter
//   {
//     void Print();
//   }

//   interface IScanner
//   {
//     void Scan();
//   }

//   interface ICopier  {
//     void Copy();
//   }

//   interface IComputerBasedMFD: IPrinter, IScanner {}

//   class Xerox : IComputerBasedMFD
//   {
//     private IPrinter _printer;
//     private IScanner _scanner;

//     public Xerox(IPrinter printer, IScanner scanner)
//     {
//       this._printer = printer;
//       this._scanner = scanner;
//     }
//     public bool Print()
//     {
//       return this._printer.Print();
//     }
//     public bool Scan()
//     {
//       return this._scanner.Scan();
//     }
//   }

//   class OldCanon : IPrinter
//   {
//     public bool Print()
//     {
//       return true;
//     }
//   }
// }
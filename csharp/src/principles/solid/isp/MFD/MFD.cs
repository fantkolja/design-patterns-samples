namespace ProgrammingPrinciples.SOLID
{
  // interface IMFD
  // {
  //   bool Print();
  //   bool Scan();
  //   bool Copy();
  // }

  interface IPrinter
  {
    bool Print();
  }

  interface IScanner
  {
    bool Scan();
  }

  interface ICopier  {
    bool Copy();
  }

  interface IComputerBasedMFD: IPrinter, IScanner {}

  class Xerox : IComputerBasedMFD
  {
    private IPrinter _printer;
    private IScanner _scanner;

    public Xerox(IPrinter printer, IScanner scanner)
    {
      this._printer = printer;
      this._scanner = scanner;
    }
    public bool Print()
    {
      return this._printer.Print();
    }
    public bool Scan()
    {
      return this._scanner.Scan();
    }
  }

  class OldCanon : IPrinter
  {
    public bool Print()
    {
      return true;
    }
  }
}
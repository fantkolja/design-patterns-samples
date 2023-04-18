using System.Text.RegularExpressions;

namespace DesignPatterns.Observer
{
  class Input
  {
    public string Value = "";
    public string ValidationPattern = "";
    private bool IsValid {
      get {
        return new Regex(this.ValidationPattern).IsMatch(this.Value);
      }
    }
  }
}
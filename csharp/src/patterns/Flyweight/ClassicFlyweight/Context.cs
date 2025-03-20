using System.Text;

namespace DesignPatterns.Flyweight
{
  class Context
  {
    private string _extrinsicProp1;
    private string _extrinsicProp2;

    private Flyweight _flyweight;

    public Context(string prop1, string prop2, int prop3, int prop4)
    {
      this._extrinsicProp1 = prop1;
      this._extrinsicProp2 = prop2;
      this._flyweight = FlyweightFactory.GetFlyweight(prop3, prop4);
    }

    public void DoSomething()
    {
      string result = new StringBuilder()
        .AppendLine($"Extrinsic props: {this._extrinsicProp1} and {this._extrinsicProp2}")
        .AppendLine($"Intrinsic props: {this._flyweight.IntrinsicProp1} and {this._flyweight.IntrinsicProp2}")
        .ToString();
      Console.WriteLine(result);
    }
  }
}
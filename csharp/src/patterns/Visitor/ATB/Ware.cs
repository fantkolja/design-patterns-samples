namespace DesignPatterns.Visitor
{
  abstract class Ware
  {
    public string Name { get; set; }
    public int Price  { get; set; }
    public Ware(string name, int price)
    {
      this.Name = name;
      this.Price = price;
    }
  }
}

// @todo: add Price + Excise
// future @todo: add Age restrictions
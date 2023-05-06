namespace DesignPatterns.Visitor
{
  class Ware
  {
    public string Name;
    public int Price;
    public Ware(string name, int price)
    {
      this.Name = name;
      this.Price = price;
    }
  }
}

// @todo: add Price + Excise
// future @todo: add Age restrictions
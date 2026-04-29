namespace DesignPatterns.Visitor;
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

// @todo: add Price + Excise
// future @todo: add Age restrictions







// Attempt #1: adding new logic to Ware children
// Pronlems: 1) we need to change existing code to add new logic, which is not good for maintenance
//           2) will result in shotgun surgery, because it violates SRP







// Attempt #2: using ExciseCalculator

class ExciseCalculator
{
    public double GetExciseForAlcohol(Alcohol alcohol) => alcohol.Price * 3;
    public double GetExciseForTobacco(Tobacco tobacco) => tobacco.Price * 5;
    public double GetExciseForMilk(MilkProduct milk) => milk.Price * 0.5;
}





// using DesignPatterns.Visitor;

// var calc = new ExciseCalculator();

// List<Ware> wares= new List<Ware>
// {
//   new Alcohol("vodyara", 2, 40),
//   new Alcohol("whiskey", 3, 50),
//   new MilkProduct("Yahotyn", 1, 15)
// };

// wares.ForEach(ware => {
//   if (ware is Alcohol alcohol)
//   {
//     calc.GetExciseForAlcohol(alcohol);
//   }
// });


// Problem: client should know which method to call for each ware, violates OCP











// Attempt #3: using Visitor pattern

// var visitor = new ExciseVisitor();

// List<Ware> wares= new List<Ware>
// {
//   new Alcohol("vodyara", 1, 40),
//   new Alcohol("whiskey", 1, 50),
//   new MilkProduct("Yahotyn", 1, 15)
// };

// wares.ForEach(ware => visitor.Visit(ware as dynamic));
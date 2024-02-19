// "Simple" Factory Method

namespace DesignPatterns.FactoryMethod
{
  class ClassicFactoryMethodCreator
  {
    public IClassicProduct CreateProduct(string name, int year) {
      IClassicProduct product;
      if (year < 2001) {
        product = new ConcreteProductA(name);
      } else {
        product = new ConcreteProductB(name);
      }
      return product;
    }
  }
}




















// Attempt #2 "Full" Factory Method
// namespace DesignPatterns.FactoryMethod
// {
//   // could be also abstract class
//   interface IClassicFactoryMethodCreator
//   {
//     public IClassicProduct CreateProduct(string name, int year);
//   }
//   class ClassicFactoryMethodCreatorX : IClassicFactoryMethodCreator
//   {
//     public IClassicProduct CreateProduct(string name, int year) {
//       IClassicProduct product;
//       if (year < 2001) {
//         product = new ConcreteProductA(name);
//       } else {
//         product = new ConcreteProductB(name);
//       }
//       return product;
//     }
//   }

//   class ClassicFactoryMethodCreatorY : IClassicFactoryMethodCreator
//   {
//     public IClassicProduct CreateProduct(string name, int year) {
//       IClassicProduct product;
//       if (year < 2011) {
//         product = new ConcreteProductA(name);
//       } else {
//         product = new ConcreteProductB(name);
//       }
//       return product;
//     }
//   }
// }





















// namespace DesignPatterns.FactoryMethod
// {
//   abstract class ClassicFactoryMethodCreator
//   {
//     abstract public IClassicProduct CreateProduct(string name, int? year);
//   }

//   class ClassicFactoryMethodCreatorA : ClassicFactoryMethodCreator
//   {
//     public override IClassicProduct CreateProduct(string name, int? year)
//     {
//       IClassicProduct result;
//       if (year.HasValue)
//       {
//         result = new ConcreteProductB(name, (int)year);
//       }
//       else
//       {
//         result = new ConcreteProductA(name);
//       }
//       return result;
//     }
//   }

//   class ClassicFactoryMethodCreatorB : ClassicFactoryMethodCreator
//   {
//     public override IClassicProduct CreateProduct(string name, int? year)
//     {
//       int derivedYear = year.HasValue ? (int)year : DateTime.Now.Year;
//       return new ConcreteProductB(name, derivedYear);
//     }
//   }
// }
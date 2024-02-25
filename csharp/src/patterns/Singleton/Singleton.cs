namespace DesignPatterns.Singleton
{
  class Singleton
  {
    private static Singleton? _instance;

    private Singleton()
    {
      Console.WriteLine("Initializing Singleton");
    }

    public static Singleton GetInstance()
    {
      if (Singleton._instance == null) {
        Singleton._instance = new Singleton();
      }
      return Singleton._instance;
    }
  }
}



// Feature #1: no public constructor

// using DesignPatterns.Singleton;

// Singleton s1 = new Singleton();




// Feature #2: initializes only once

// using DesignPatterns.Singleton;

// Singleton s1 = Singleton.GetInstance();
// Singleton s2 = Singleton.GetInstance();




// Problem #1: breakes with a derived class

// namespace DesignPatterns.Singleton
// {
//   class Singleton
//   {
//     private static Singleton? _instance;

//     private Singleton()
//     {
//       Console.WriteLine("Initializing Singleton");
//     }

//     public static Singleton GetInstance()
//     {
//       if (Singleton._instance == null) {
//         Singleton._instance = new Singleton();
//       }
//       return Singleton._instance;
//     }

//     public class ChildSingleton : Singleton
//     {

//     }
//   }
// }
//
// using DesignPatterns.Singleton;

// Singleton s1 = Singleton.GetInstance();
// Singleton s2 = Singleton.GetInstance();

// Singleton cs1 = Singleton.ChildSingleton.GetInstance();
// Singleton cs2 = Singleton.ChildSingleton.GetInstance();

// Singleton.ChildSingleton dcs1 = new Singleton.ChildSingleton();
// Singleton.ChildSingleton dcs2 = new Singleton.ChildSingleton();



// fix of Problem #1
// namespace DesignPatterns.Singleton
// {
//   sealed class Singleton
//   {
//     private static Singleton? _instance;

//     private Singleton()
//     {
//       Console.WriteLine("Initializing Singleton");
//     }

//     public static Singleton GetInstance()
//     {
//       if (Singleton._instance == null) {
//         Singleton._instance = new Singleton();
//       }
//       return Singleton._instance;
//     }

//     public class ChildSingleton : Singleton
//     {

//     }
//   }
// }











// Problem #2: thread unsafe

// using DesignPatterns.Singleton;

// for (int i = 0; i < 10; i++)
// {
//   var t = new Thread(() => Singleton.GetInstance());
//   t.Start();
// }


// fix of Problem #2
// namespace DesignPatterns.Singleton
// {
//   sealed class Singleton
//   {
//     private static Singleton? _instance;
//     private static object _refObj = new object();

//     private Singleton()
//     {
//       Console.WriteLine("Initializing Singleton");
//     }

//     public static Singleton GetInstance()
//     {
//       if (Singleton._instance == null) {
//         lock(Singleton._refObj)
//         {
//           if (Singleton._instance == null) {
//             Singleton._instance = new Singleton();
//           }
//         }
//       }
//       return Singleton._instance;
//     }
//   }
// }

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











// With derived class

// namespace DesignPatterns.Singleton
// {
//   class Singleton
//   {
//     private static int _counter = 0;
//     private static Singleton? _instance;

//     private Singleton()
//     {
//       Console.WriteLine($"Initializing Singleton #${++Singleton._counter}");
//     }

//     public static Singleton GetInstance()
//     {
//       if (Singleton._instance == null) {
//         Singleton._instance = new Singleton();
//       }
//       return Singleton._instance;
//     }

//     public class DerivedSingleton : Singleton
//     {
      
//     }
//   }

    // public class DerivedSingleton : Singleton
    // {
      
    // }
// }

    // @todo: move as nested
    
    // Singleton singleton = Singleton.GetInstance();

    // Singleton classicDerivedSingleton = Singleton.DerivedSingleton.GetInstance();

    // var weirdDerivedSingleton = new Singleton.DerivedSingleton();













// thread safe

// namespace DesignPatterns.Singleton
// {
//   class Singleton
//   {
//     private static int _counter = 0;
//     private static Singleton? _instance;

//     private static object lockRef = new object();

//     private Singleton()
//     {
//       Console.WriteLine($"Initializing Singleton #${++Singleton._counter}");
//     }

//     public static Singleton GetInstance()
//     {
//       if (Singleton._instance == null) {
//         lock(Singleton.lockRef)
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


// for (int i = 0; i < 100; i++)
// {
//   var t = new Thread(() => Singleton.GetInstance());
//   t.Start();
// }
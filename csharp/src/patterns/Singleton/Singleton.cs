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
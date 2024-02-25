namespace DesignPatterns.Singleton
{
  // for fixed set of types
  public enum MultitonType
  {
    X,
    Y,
    Z,
  }

  public class Multiton
  {
    private static readonly Dictionary<MultitonType, Multiton> _instances =
        new Dictionary<MultitonType, Multiton>();

    private MultitonType type;

    private Multiton(MultitonType type)
    {
        this.type = type;
    }

    public static Multiton GetInstance(MultitonType type)
    {
      if (!Multiton._instances.TryGetValue(type, out Multiton? instance))
      {
        Console.WriteLine($"Creating new Multitone with type {type}");
        instance = new Multiton(type);
        Multiton._instances.Add(type, instance);
      }

      return instance;
    }
  }
}

// Multiton mx1 = Multiton.GetInstance(MultitonType.X);
// Multiton my1 = Multiton.GetInstance(MultitonType.Y);
// Multiton my2 = Multiton.GetInstance(MultitonType.Y);
// Multiton mz1 = Multiton.GetInstance(MultitonType.Z);
// Multiton mz2 = Multiton.GetInstance(MultitonType.Z);
// Multiton mz3 = Multiton.GetInstance(MultitonType.Z);
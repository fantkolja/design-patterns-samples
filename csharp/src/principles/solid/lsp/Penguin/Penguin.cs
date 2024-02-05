namespace ProgrammingPrinciples.SOLID
{
  public interface IBird
  {
    public void Walk();
    public void Fly();
  }


  public class Parrot : IBird
  {
    public void Walk()
    {
      Console.WriteLine("Walking");
    }
    public void Fly()
    {
      Console.WriteLine("Flying");
    }
  } // ok 

  public class Penguin : IBird
  {
    public void Walk()
    {
      Console.WriteLine("Walking");
    }
    public void Fly()
    {
      throw new NotImplementedException();   // it's break the principle of LSP. Penguin can not fly.
    }
  }






  // public interface IBird
  // {
  //   // to do;
  // }

  // public interface IFlyingBird : IBird
  // {
  //     public void Fly();
  // }

  // public interface IWalkingBird : IBird
  // {
  //   public void Walk();
  // }

  // public class Parrot : IFlyingBird, IWalkingBird
  // {
  //   public void Walk()
  //   {
  //     Console.WriteLine("Walking");
  //   }
  //   public void Fly()
  //   {
  //     Console.WriteLine("Flying");
  //   }
  // }

  // public class Penguin : IWalkingBird
  // {
  //   public void Walk()
  //   {
  //     Console.WriteLine("Walking");
  //   }
  // }
}
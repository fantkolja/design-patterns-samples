namespace DesignPatterns.Builder
{
  static class FluentDirector
  {
    public class FullBuilder : FilledProfileBuilder<FullBuilder> {}
    public class InitialBuilder : SignedUpProfileBuilder<InitialBuilder> {}

    static public InitialBuilder GetSignedUpProfileBuilder()
    {
      return new InitialBuilder();
    }

    static public FullBuilder GetFilledProfileBuilder()
    {
      return new FullBuilder();
    }
  }
}


// Person mykola = FluentDirector.GetSignedUpProfileBuilder()
//   .Called("Mykola")
//   .WithEmail("fantkolja@gmail.com")
//   .GetPerson();

// Person vasya = FluentDirector.GetFilledProfileBuilder()
//   .Called("Mykola")
//   .WithEmail("fantkolja@gmail.com")
//   .WorkingAsA("Coder")
//   .GetPerson();
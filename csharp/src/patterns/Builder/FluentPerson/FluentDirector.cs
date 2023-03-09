// namespace DesignPatterns.Builder
// {
//   static class FluentDirector
//   {
//     static public Person CreateSignedUpPerson()
//     {
//       return new SignedUpProfileBuilder()
//         .Called("Mykola")
//         .WithEmail("fantkolja@gmail.com")
//         .GetPerson();
//     }

//     static public Person GetFilledProfilePerson()
//     {
//       return new FilledProfileBuilder()
//         .Called("Mykola")
//         .WithEmail("fantkolja@gmail.com")
//         .WorkingAsA("Coder")
//         .GetPerson();
//     }
//   }
// }


// namespace DesignPatterns.Builder
// {
//   static class FluentDirector
//   {
//     private class InitialBuilder : SignedUpProfileBuilder<InitialBuilder> {}
//     private class FullBuilder : FilledProfileBuilder<FullBuilder> {}

//     static public Person CreateSignedUpPerson()
//     {
//       return new InitialBuilder()
//         .Called("Mykola")
//         .WithEmail("fantkolja@gmail.com")
//         .GetPerson();
//     }

//     static public Person GetFilledProfilePerson()
//     {
//       return new FullBuilder()
//         .Called("Mykola")
//         .WithEmail("fantkolja@gmail.com")
//         .WorkingAsA("Coder")
//         .GetPerson();
//     }
//   }
// }
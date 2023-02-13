namespace ProgrammingPrinciples.SOLID
{
  class DIPDemo
  {
    public static void show()
    {
      var videoApp = new VideoApp();
      videoApp.AddVideo("SOLID");
      videoApp.PlayVideo("SOLID");
    }
  }
}

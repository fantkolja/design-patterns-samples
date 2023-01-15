namespace ProgrammingPrinciples.SOLID
{
  class LSPDemo
  {
    // private static bool _joinDBTables(MongoDatabase db, string table1, string table2)
    // private static bool _joinDBTables(Database db, string table1, string table2)
    // {
    //   return db.JoinTables(table1, table2);
    // }

    private static int calculateArea(Rectangle rect)
    {
      return rect.Width * rect.Height;
    }
    public static void show()
    {
      // Database sqlDB = new MySQLDatabase();
      // LSPDemo._joinDBTables(sqlDB, "table1", "table2");
      // Database mongoDB = new MongoDatabase();
      // LSPDemo._joinDBTables(mongoDB, "table1", "table2");


      Rectangle rect = new Square();
      rect.Width = 4;
      // rect.Height = 5;

      Console.WriteLine(calculateArea(rect));
    }
  }
}

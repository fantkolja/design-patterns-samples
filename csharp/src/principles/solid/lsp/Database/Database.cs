namespace ProgrammingPrinciples.SOLID
{
  public class Database
  {
    public bool Connect(string url)
    {
      Console.WriteLine("Connected to the DB");
      return true;
    }
    public bool Read(string query)
    {
      Console.WriteLine($"Reading {query}");
      return true;
    }
    public bool Write(string url)
    {
      Console.WriteLine("Writing to the DB");
      return true;
    }
    public bool JoinTables(string table1, string table2)
    {
      Console.WriteLine($"Joining {table1} and {table2}");
      return true;
    }
  }


  public class MySQLDatabase : Database
  {
    public bool CreateProcedure(string body)
    {
      Console.WriteLine("Creating procedure");
      return true;
    }
  }


  public class MongoDatabase : Database
  {
    public bool MergeTables(string table1, string table2)
    {
      Console.WriteLine($"Merging {table1} and {table2}");
      return true;
    }

    // public bool JoinTables(string table1, string table2)
    // {
    //   throw new NotSupportedException();
    // }
  }
}


    // private static bool _joinDBTables(MongoDatabase db, string table1, string table2)
    // private static bool _joinDBTables(Database db, string table1, string table2)
    // {
    //   return db.JoinTables(table1, table2);
    // }

      // Database sqlDB = new MySQLDatabase();
      // LSPDemo._joinDBTables(sqlDB, "table1", "table2");
      // Database mongoDB = new MongoDatabase();
      // LSPDemo._joinDBTables(mongoDB, "table1", "table2");
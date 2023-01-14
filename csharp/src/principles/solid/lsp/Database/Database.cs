namespace ProgrammingPrinciples.SOLID
{
  public class Database
  {
    public async Task<bool> Connect(string url)
    {
      await Task.Delay(10);
      Console.WriteLine("Connected to the DB");
      return true;
    }
    public async Task<bool> Read(string query)
    {
      await Task.Delay(10);
      Console.WriteLine($"Reading {query}");
      return true;
    }
    public async Task<bool> Write(string url)
    {
      await Task.Delay(10);
      Console.WriteLine("Writing to the DB");
      return true;
    }
    public async Task<bool> JoinTables(string table1, string table2)
    {
      await Task.Delay(10);
      Console.WriteLine($"Joining {table1} and {table2}");
      return true;
    }
  }


  public class MySQLDatabase : Database
  {
    public async Task<bool> CreateProcedure(string body)
    {
      await Task.Delay(10);
      Console.WriteLine("Creating procedure");
      return true;
    }
  }


  public class MongoDatabase : Database
  {
    public async Task<bool> MergeTables(string table1, string table2)
    {
      await Task.Delay(10);
      Console.WriteLine($"Merging {table1} and {table2}");
      return true;
    }

    // public async Task<bool> JoinTables(string table1, string table2)
    // {
    //   throw new NotSupportedException();
    // }
  }
}

// @todo: show the corresponding JS example
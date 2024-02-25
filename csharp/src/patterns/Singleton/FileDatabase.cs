namespace DesignPatterns.Singleton
{
  sealed class FileDatabase
  {
    private static FileDatabase? _instance;
    private static object _lockObj = new object();

    private FileDatabase()
    {
      this._countries = this._populateCountries();
    }

    public static FileDatabase GetInstance()
    {
      if (_instance == null) {
        lock(FileDatabase._lockObj)
        {
          if (_instance == null) {
            _instance = new FileDatabase();
          }
        }
      }
      return _instance;
    }

    private Dictionary<string, string> _countries = new();

    private Dictionary<string, string> _populateCountries()
    {
      return File.ReadAllLines("./tmp/data.csv").ToDictionary(
        list => list.Split(',')[0],
        list => list.Split(',')[1]
      );
    }

    public string GetAbbreviation(string country)
    {
      return this._countries[country];
    }
  }
}
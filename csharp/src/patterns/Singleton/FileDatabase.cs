namespace DesignPatterns.Singleton
{
  class FileDatabase
  {
    private static FileDatabase? _instance;

    private Dictionary<string, string> _countries = new();

    private Dictionary<string, string> _populateCountries()
    {
      return File.ReadAllLines("./tmp/data.csv").ToDictionary(
        list => list.Split(',')[0],
        list => list.Split(',')[1]
      );
    }

    private FileDatabase()
    {
      this._countries = this._populateCountries();
    }

    public static FileDatabase GetInstance()
    {
      if (_instance == null) {
        _instance = new FileDatabase();
      }
      return _instance;
    }

    public string getAbbreviation(string country)
    {
      return this._countries[country];
    }
  }
}
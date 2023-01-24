namespace DesignPatterns.Builder
{
  class ClassicProduct
  {
    private string? _feature1;
    private string? _feature2;
    private string? _feature3;

    public string SetFeature1(string val)
    {
      return this._feature1 = val;
    }

    public string SetFeature2(string val)
    {
      return this._feature2 = val;
    }

    public string SetFeature3(string val)
    {
      return this._feature3 = val;
    }
  }
}
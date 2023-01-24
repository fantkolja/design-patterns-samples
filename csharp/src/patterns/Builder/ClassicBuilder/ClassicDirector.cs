namespace DesignPatterns.Builder
{
  class ClassicDirector
  {
    private ClassicBuilder _builder;

    public ClassicDirector SetBuilder(ClassicBuilder builder)
    {
      this._builder = builder;
      return this;
    }

    public ClassicDirector(ClassicBuilder builder)
    {
      this.SetBuilder(builder);
    }

    public ClassicProduct GetFullFeaturedProduct()
    {
      return this._builder
        .BuildFeatureA()
        .BuildFeatureB()
        .BuildFeatureC()
        .GetProduct();
    } 

    public ClassicProduct GetMvpProduct()
    {
      return this._builder
        .BuildFeatureA()
        .GetProduct();
    } 
  }
}
namespace DesignPatterns.Builder
{
  interface ClassicBuilder
  {
    ClassicBuilder BuildFeatureA();
    ClassicBuilder BuildFeatureB();
    ClassicBuilder BuildFeatureC();

    ClassicProduct GetProduct();
  }

  class ConcreteClassicBuilder : ClassicBuilder
  {
    private ClassicProduct _product = new ClassicProduct();

    private void _reset()
    {
      this._product = new ClassicProduct();
    }

    public ClassicProduct GetProduct()
    {
      ClassicProduct product = this._product;
      this._reset();
      return product;
    }

    ClassicBuilder ClassicBuilder.BuildFeatureA()
    {
      this._product.SetFeature1("val1");
      return this;
    }

    ClassicBuilder ClassicBuilder.BuildFeatureB()
    {
      this._product.SetFeature2("val2");
      return this;
    }

    ClassicBuilder ClassicBuilder.BuildFeatureC()
    {
      this._product.SetFeature3("val3");
      return this;
    }

  }
}
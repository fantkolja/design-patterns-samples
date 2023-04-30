namespace DesignPatterns.TemplateMethod
{
  abstract class SmartRepository
  {
    public Guid Save(Dictionary<string, string> data)
    {
      if (!this._validateData(data))
      {
        throw new ArgumentException("Invalid data!");
      }
      var transformedData = this._transformBeforeSave(data);
      this._beforeSave(data, transformedData);
      var id = this._processSaving(transformedData);
      this._afterSave(id);
      return id;
    }
    protected virtual bool _validateData(Dictionary<string, string> data)
    {
      return true;
    }
    protected virtual Dictionary<string, string> _transformBeforeSave(Dictionary<string, string> data)
    {
      return data;
    }
    protected virtual void _beforeSave(Dictionary<string, string> data, Dictionary<string, string> transformedData)
    {
    }
    abstract protected Guid _processSaving(Dictionary<string, string> data);
    protected virtual void _afterSave(Guid id)
    {
    }
  }
}
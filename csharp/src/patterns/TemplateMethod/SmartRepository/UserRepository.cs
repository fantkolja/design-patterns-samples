namespace DesignPatterns.TemplateMethod
{
  class UserRepository : SmartRepository
  {
    protected override Guid _processSaving(Dictionary<string, string> data)
    {
      return Guid.NewGuid();
    }
  }
}
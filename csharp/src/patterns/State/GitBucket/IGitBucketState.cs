namespace DesignPatterns.State
{
  interface IGitBucketState
  {
    public void OnCreated();
    public void OnSubmit();
    public void OnDecline();
  }
}
namespace DesignPatterns.Observer
{
  class Tooltip
  {
    public SubmitButton WrappedButton { set; get; }
    public string Text { set; get; }
  }
}



// Version 1: classic
// namespace DesignPatterns.Observer
// {
//   class Tooltip : ISubscriber
//   {
//     public SubmitButton WrappedButton { set; get; }
//     public string Text { set; get; }

//     public void Process()
//     {
//       Text = "Submitting form";
//     }
//   }
// }
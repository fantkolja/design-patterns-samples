namespace DesignPatterns.Observer
{
  class Tooltip
  {
    public SubmitButton WrappedButton { set; get; }
    public string Text { set; get; }
  }
}



// Version 1: classsic
// namespace DesignPatterns.Observer
// {
//   class Tooltip : ISubscriber
//   {
//     public SubmitButton WrappedButton { set; get; }
//     public string Text { set; get; }

//     public void OnSubmit()
//     {
//       Text = "Submitting form";
//     }
//   }
// }
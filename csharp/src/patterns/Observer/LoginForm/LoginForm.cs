namespace DesignPatterns.Observer
{
  class LoginForm
  {
    public List<Input> Inputs = new List<Input>();
    public SubmitButton Button = new SubmitButton();

    public void ValidateInputs() { }
  }
}



// var input1 = new Input();
// var input2 = new Input();
// var button = new SubmitButton();
// var form = new LoginForm();
// var tooltip = new Tooltip();
//
// form.Inputs.Add(input1);
// form.Inputs.Add(input2);
// form.Button = button;
// tooltip.WrappedButton = button;
//
// button.Click(); // потрібно викликати form.ValidateInputs() і змінити tooltip.Text







// Version 1: classic

// namespace DesignPatterns.Observer
// {
//   interface ISubscriber
//   {
//     public void OnSubmit();
//   }

//   class LoginForm : ISubscriber
//   {
//     public List<Input> Inputs = new List<Input>();
//     public SubmitButton Button = new SubmitButton();

//     public void OnSubmit()
//     {
//       ValidateInputs();
//     }

//     public void ValidateInputs() { }
//   }
// }







// Version 2: with lambdas

// namespace DesignPatterns.Observer
// {
//   class LoginForm
//   {
//     public List<Input> Inputs = new List<Input>();
//     public SubmitButton Button = new SubmitButton();

//     public void ValidateInputs() { }
//   }
// }

// using DesignPatterns.Observer;

// var form = new LoginForm();
// var tooltip = new Tooltip();
// var button = new SubmitButton();

// button.AddSubscriber(() => form.ValidateInputs());

// button.Click();









// Version 3: with built-in events

// namespace DesignPatterns.Observer
// {
//   class LoginForm
//   {
//     public List<Input> Inputs = new List<Input>();

//     public void OnSubmit()
//     {
//       Console.WriteLine("Form submitted");
//     }
//   }
// }


// using DesignPatterns.Observer;

// var form = new LoginForm();
// var button = new SubmitButton();

// button.Submitted += (object? sender, EventArgs e) => form.OnSubmit();

// button.Click();

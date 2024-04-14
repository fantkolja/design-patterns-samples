namespace DesignPatterns.Observer
{
  class LoginForm
  {
    public List<Input> Inputs = new List<Input>();
    public SubmitButton Button = new SubmitButton();

    public void OnSubmit()
    {
      
    }
  }
}













// Version 1: with inner initialization

// namespace DesignPatterns.Observer
// {
//   class LoginForm : Subscriber
//   {
//     public List<Input> Inputs = new List<Input>();

//     public SubmitButton Button;

//     public LoginForm()
//     {
//       Button = new SubmitButton();
//       Button.Subscribe(this);
//     }

//     public void OnSubmit()
//     {
//       Console.WriteLine("Form submitted");
//     }

//     public void Process()
//     {
//         this.OnSubmit();
//     }
//   }
// }

// using DesignPatterns.Observer;

// var form = new LoginForm();

// form.Button.Click();







// Version 2: with outer initialization

// namespace DesignPatterns.Observer
// {
//   class LoginForm : Subscriber
//   {
//     public List<Input> Inputs = new List<Input>();

//     public void OnSubmit()
//     {
//       Console.WriteLine("Form submitted");
//     }

//     public void Process()
//     {
//         this.OnSubmit();
//     }
//   }
// }

// using DesignPatterns.Observer;

// var form = new LoginForm();
// var button = new SubmitButton();

// button.Subscribe(form);

// button.Click();





// Version 3: with lambdas

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

// button.Subscribe(() => form.OnSubmit());

// button.Click();




// Version 4: with built-in events

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
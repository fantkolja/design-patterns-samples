// Version 1 - not working with inheritance

namespace DesignPatterns.Builder
{
  abstract class PersonBuilder
  {
    protected Person _person = new Person();
    protected void _reset()
    {
      this._person = new Person();
    }

    public Person GetPerson()
    {
      Person person = this._person;
      this._reset();
      return person;
    }
  }
  interface BasicProfileBuilder
  {
    BasicProfileBuilder Called(String name);
    BasicProfileBuilder WithEmail(String email);
  }

  class SignedUpProfileBuilder : PersonBuilder, BasicProfileBuilder
  {
    public BasicProfileBuilder WithEmail(string email)
    {
      this._person.Email = email;
      return this;
    }

    public BasicProfileBuilder Called(string name)
    {
      this._person.Name = name;
      return this;
    }
  }

  class FilledProfileBuilder : SignedUpProfileBuilder 
  {
    public BasicProfileBuilder WorkingAsA(string job)
    {
      this._person.Job = job;
      return this;
    }

    public BasicProfileBuilder Earning(string salary)
    {
      this._person.Salary = salary;
      return this;
    }
  }
}


























// namespace DesignPatterns.Builder
// {
//   abstract class PersonBuilder
//   {
//     protected Person _person = new Person();
//     protected void _reset()
//     {
//       this._person = new Person();
//     }

//     public Person GetPerson()
//     {
//       Person person = this._person;
//       this._reset();
//       return person;
//     }
//   }
//   interface BasicProfileBuilder<T> where T : BasicProfileBuilder<T>
//   {
//     T Called(String name);
//     T WithEmail(String email);
//   }

//   class SignedUpProfileBuilder<T> : PersonBuilder, BasicProfileBuilder<T> where T : SignedUpProfileBuilder<T>
//   {
//     public T WithEmail(string email)
//     {
//       this._person.Email = email;
//       return (T) this;
//     }

//     public T Called(string name)
//     {
//       this._person.Name = name;
//       return (T) this;
//     }
//   }

//   class FilledProfileBuilder<T> : SignedUpProfileBuilder<T> where T : FilledProfileBuilder<T>
//   {
//     public T WorkingAsA(string job)
//     {
//       this._person.Job = job;
//       return (T) this;
//     }

//     public T Earning(string salary)
//     {
//       this._person.Salary = salary;
//       return (T) this;
//     }
//   }
// }

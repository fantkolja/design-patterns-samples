// Version 1 - not working with inheritance

// namespace DesignPatterns.Builder
// {
//   interface ProfileBuilder
//   {
//     ProfileBuilder Called(String name);
//     ProfileBuilder WithEmail(String email);
//     public Person GetPerson();
//   }

//   class SignedUpProfileBuilder : ProfileBuilder
//   {
//     protected Person _person = new Person();
//     private void _reset()
//     {
//       this._person = new Person();
//     }

//     public Person GetPerson()
//     {
//       Person person = this._person;
//       this._reset();
//       return person;
//     }
//     public ProfileBuilder WithEmail(string email)
//     {
//       this._person.Email = email;
//       return this;
//     }

//     public ProfileBuilder Called(string name)
//     {
//       this._person.Name = name;
//       return this;
//     }
//   }

//   class FilledProfileBuilder : SignedUpProfileBuilder 
//   {
//     public ProfileBuilder WorkingAsA(string job)
//     {
//       this._person.Job = job;
//       return this;
//     }

//     public ProfileBuilder Earning(string salary)
//     {
//       this._person.Salary = salary;
//       return this;
//     }
//   }
// }


namespace DesignPatterns.Builder
{
  interface IPersonBuilder<T>
  {
    public T Called(string name);
    public T WithEmail(string email);
  }
  abstract class PersonBuilder
  {
    protected Person _person = new Person();
    private void _reset()
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

  class SignedUpProfileBuilder<T>
   : PersonBuilder, IPersonBuilder<T>
   where T : SignedUpProfileBuilder<T>
  {
    public T Called(string name)
    {
      this._person.Name = name;
      return (T) this;
    }

    public T WithEmail(string email)
    {
      this._person.Email = email;
      return (T) this;
    }

  }

  class FilledProfileBuilder<T>
    : SignedUpProfileBuilder<FilledProfileBuilder<T>>
    where T : FilledProfileBuilder<T>
  {
    public T WorkingAsA(string job)
    {
      this._person.Job = job;
      return (T) this;
    }

    public T Earning(string salary)
    {
      this._person.Salary = salary;
      return (T) this;
    }
  }
}
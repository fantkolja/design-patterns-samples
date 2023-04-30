namespace DesignPatterns.ChainOfResponsibility
{
  class User
  {
    public enum Role
    {
      Admin,
      User,
      Finance,
    }
    public Role UserRole { get; private set; } = Role.User;

    public User(Role role)
    {
      this.UserRole = role;
    }
  }
}
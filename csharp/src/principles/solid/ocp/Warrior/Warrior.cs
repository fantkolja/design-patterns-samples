namespace ProgrammingPrinciples.SOLID
{
  class Warrior
  {
    private string _name { get; set; }
    private Weapon _weapon { get; set; }

    public Warrior(string name, Weapon weapon)
    {
      this._name = name;
      this._weapon = weapon;
    }

    public Weapon ChangeWeapon(Weapon newWeapon)
    {
      this._weapon = newWeapon;
      return newWeapon;
    }

    public bool Attack()
    {
      this._weapon.Attack();
      return true;
    }
  }
}
namespace ProgrammingPrinciples.SOLID
{
  interface Attacker
  {
    public void Attack();
  }

  class Weapon: Attacker
  {
    public enum Type
    {
      MELEE,
      RANGED,
    }

    private Type _type { get; set; }
    private int _damage { get; set; }
    private int _range { get; set; }
    private string _name { get; set; }
  
    public Weapon(string name, int damage, int range, Type type)
    {
      this._name = name;
      this._damage = damage;
      this._range = range;
      this._type = type;
    }

    // BREAKS THE OCP PRINCIPLE
    // public void Attack()
    // {
    //   if (this._type == Weapon.Type.MELEE) {
    //     Console.WriteLine($"Hitting with {this._name}, dealing {this._damage} damage");
    //   } else if (this._type == Weapon.Type.RANGED) {
    //     Console.WriteLine($"Firing with {this._name}, dealing {this._damage} damage from range {this._range}");
    //   }
    // }

    public virtual void Attack()
    {
      throw new NotImplementedException();
    }

    public class Sword: Weapon
    {
      public Sword(string name, int damage, int range) : base(name, damage, range, Weapon.Type.MELEE) {}
      public override void Attack()
      {
        Console.WriteLine($"Hitting with {this._name}, dealing {this._damage} damage");
      }
    }

    public class Bow: Weapon
    {
      public Bow(string name, int damage, int range) : base(name, damage, range, Weapon.Type.RANGED) {}
      public override void Attack()
      {
        Console.WriteLine($"Firing with {this._name}, dealing {this._damage} damage from range {this._range}");
      }
    }
  }
}